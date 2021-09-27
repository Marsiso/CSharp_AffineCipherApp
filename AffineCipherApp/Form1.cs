using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AffineCipherApp
{
    public partial class BasicView : Form
    {
        public BasicView()
        {
            InitializeComponent();
            A = 5;
            B = 9;
            M = 26;
            AffineCipher.BuildEncryptionDictionary(A, B, (int)M);
            listViewSubstitution.Columns.Add("Input Letter", 128, HorizontalAlignment.Left);
            listViewSubstitution.Columns.Add("Output Letter", 128, HorizontalAlignment.Left);
            listViewFilter.Columns.Add("Input Letter", 128, HorizontalAlignment.Left);
            listViewFilter.Columns.Add("Output Letter", 128, HorizontalAlignment.Left);
            BuildSubstitutionTable();
            BuildFilterTable();
        }

        internal int A { get; private set; }
        internal int B { get; private set; }
        internal uint M { get; private set; }

        //TODO move build dictionary to an eventhandler
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            const string s1 = "Open Text";
            const string s2 = "Cypher";
            if (String.CompareOrdinal(labelInput.Text, s1) == 0) return;
            labelInput.Text = s1;
            labelOutput.Text = s2;

            AffineCipher.BuildEncryptionDictionary(A, B, (int)M);
            txtBoxOut.Text = String.CompareOrdinal(labelOutput.Text, s2) == 0
                ? AffineCipher.FormatAndEncryptOpenText(txtBoxIn.Text)
                : AffineCipher.FormatAndDecryptCipher(txtBoxIn.Text);
            BuildSubstitutionTable();
            BuildFilterTable();
        }

        //TODO move build dictionary to an eventhandler
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            const string s1 = "Cypher";
            const string s2 = "Open Text";
            if (String.CompareOrdinal(labelInput.Text, s1) == 0) return;
            labelInput.Text = s1;
            labelOutput.Text = s2;

            AffineCipher.BuildDecryptionDictionary(A, B, (int)M);
            txtBoxOut.Text = String.CompareOrdinal(labelOutput.Text, s1) == 0
                ? AffineCipher.FormatAndEncryptOpenText(txtBoxIn.Text)
                : AffineCipher.FormatAndDecryptCipher(txtBoxIn.Text);
            BuildSubstitutionTable();
            BuildFilterTable();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            btnOptions_Click();
        }

        /// <summary>
        /// Hide or display components of option's sub-panel.
        /// </summary>
        private void btnOptions_Click()
        {
            if (subPanelTables.Visible && !subPanelOpt.Visible)
            {
                subPanelTables.Visible = false;
            }
            bool isVisible = !subPanelOpt.Visible;
            subPanelOpt.Visible = isVisible;
            tblLayoutPanelLeft.Visible = isVisible;
            txtBoxVarA.Visible = isVisible;
            labelVarA.Visible = isVisible;
            txtBoxVarB.Visible = isVisible;
            labelVarB.Visible = isVisible;
            txtBoxVarM.Visible = isVisible;
            labelVarM.Visible = isVisible;
            checkBoxStdAplhabet.Visible = isVisible;
            checkBoxExtAplhabet.Visible = isVisible;
            btnOptSave.Visible = isVisible;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            const string invalidValue = @"?";
            if (String.CompareOrdinal(txtBoxVarM.Text, invalidValue) == 0)
            {
                return;
            }
            if (System.Numerics.BigInteger.GreatestCommonDivisor(A, M) != 1)
            {
                return;
            }

            const string s = "Cypher";

            if (String.CompareOrdinal(labelInput.Text, s) == 0)
            {
                AffineCipher.BuildDecryptionDictionary(A, B, (int)M);
                txtBoxOut.Text = AffineCipher.FormatAndDecryptCipher(txtBoxIn.Text);
            }
            else
            {
                AffineCipher.BuildEncryptionDictionary(A, B, (int)M);
                txtBoxOut.Text = AffineCipher.FormatAndEncryptOpenText(txtBoxIn.Text);
            }

            if (txtBoxIn.ReadOnly)
            {
                txtBoxIn.ReadOnly = false;
            }

            BuildSubstitutionTable();
            BuildFilterTable();
        }

        /// <summary>
        /// Handles events called upon alphabets checkbox changes and updates depending objects.
        /// User's input is locked until save button is pressed and all inputs are valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxStdExtAlphabet_CheckedChanged(object sender, EventArgs e)
        {
            if (!txtBoxIn.ReadOnly)
            {
                txtBoxIn.ReadOnly = true;
            }
            if (checkBoxStdAplhabet.Checked && checkBoxExtAplhabet.Checked || !checkBoxStdAplhabet.Checked && !checkBoxExtAplhabet.Checked)
            {
                txtBoxVarM.Text = @"?";
                return;
            }

            txtBoxVarM.Text = checkBoxStdAplhabet.Checked
                ? "26"
                : "36";

            const uint mStd = 26;
            const uint mExt = 36;

            M = checkBoxStdAplhabet.Checked
                ? mStd
                : mExt;

            AffineCipher.Instance = checkBoxStdAplhabet.Checked
                ? AffineCipher.StdAlphabet
                : AffineCipher.ExtAlphabet;
        }

        /// <summary>
        /// Handles events called upon text box changes and updates depending objects.
        /// User's input is locked until save button is pressed and all inputs are valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxVarA_TextChanged(object sender, EventArgs e)
        {
            if (!txtBoxIn.ReadOnly)
            {
                txtBoxIn.ReadOnly = true;
            }
            const string allowedString = @"-";
            if (String.CompareOrdinal(txtBoxVarA.Text, allowedString) == 0)
            {
                A = 0;
                return;
            }
            if (int.TryParse(txtBoxVarA.Text, out int a))
            {
                A = a;
            }
            else
            {
                txtBoxVarA.Text = @"0";
            }
        }

        /// <summary>
        /// Handles events called upon text box changes and updates depending objects.
        /// User's input is locked until save button is pressed and all inputs are valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxVarB_TextChanged(object sender, EventArgs e)
        {
            if (!txtBoxIn.ReadOnly)
            {
                txtBoxIn.ReadOnly = true;
            }
            const string allowedString = @"-";
            if (String.CompareOrdinal(txtBoxVarB.Text, allowedString) == 0)
            {
                B = 0;
                return;
            }
            if (int.TryParse(txtBoxVarB.Text, out int b))
            {
                B = b;
            }
            else
            {
                txtBoxVarB.Text = @"0";
            }
        }

        private void txtBoxIn_TextChanged(object sender, EventArgs e)
        {
            const string s = "Cypher";

            txtBoxOut.Text = String.CompareOrdinal(labelOutput.Text, s) == 0
                ? AffineCipher.FormatAndEncryptOpenText(txtBoxIn.Text)
                : AffineCipher.FormatAndDecryptCipher(txtBoxIn.Text);
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            if (subPanelOpt.Visible && !subPanelTables.Visible)
            {
                subPanelOpt.Visible = false;
            }
            bool isVisible = !subPanelTables.Visible;
            subPanelTables.Visible = isVisible;
            tblLeft.Visible = isVisible;
            btnSubstitution.Visible = isVisible;
            listViewSubstitution.Visible = isVisible;
            btnFilter.Visible = isVisible;
            listViewFilter.Visible = isVisible;
        }

        private void BuildSubstitutionTable()
        {
            listViewSubstitution.Items.Clear();

            ListViewItem row;
            foreach (var Letters in AffineCipher.AffineCipherDictionary)
            {
                row = new ListViewItem(Letters.Key.ToString());
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, Letters.Value.ToString()));
                listViewSubstitution.Items.Add(row);
            }

            const string s = "Cypher";
            if (String.CompareOrdinal(labelOutput.Text, s) == 0)
            {
                row = new ListViewItem("(whitespace)");
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, AffineCipher.FormatAndEncryptOpenText("XMEZERAX")));
                listViewSubstitution.Items.Add(row);
            }

            row = new ListViewItem("(else)");
            row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "(none)"));
            listViewSubstitution.Items.Add(row);
        }

        private void BuildFilterTable()
        {
            listViewFilter.Items.Clear();

            ListViewItem row;
            foreach (var Letters in AffineCipher.ConversionDictionary)
            {
                row = new ListViewItem(Letters.Key.ToString());
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, Letters.Value.ToString()));
                listViewFilter.Items.Add(row);
            }

            const string s = "Cypher";
            if (String.CompareOrdinal(labelOutput.Text, s) == 0)
            {
                row = new ListViewItem("(whitespace)");
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "XMEZERAX"));
                listViewFilter.Items.Add(row);
            }
            else
            {
                const string whitespace = "XMEZERAX";
                StringBuilder whitespaceCypher = new StringBuilder(capacity: whitespace.Length);

                foreach (var c in whitespace)
                {
                    foreach (var Letters in AffineCipher.AffineCipherDictionary)
                    {
                        if (Letters.Value != c) continue;
                        whitespaceCypher.Append(Letters.Key);
                        break;
                    }
                }

                row = new ListViewItem(whitespaceCypher.ToString());
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "(whitespace)"));
                listViewFilter.Items.Add(row);
            }

            row = new ListViewItem("(else)");
            row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "(none)"));
            listViewFilter.Items.Add(row);
        }
    }
}