using System;
using System.Windows.Forms;

namespace WordSearchApp
{
    public partial class WordSearchForm : Form
    {
        public WordSearchForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string word = wordInput.Text;
            string text = textInput.Text;
            WordSearchLogic logic = new WordSearchLogic(text);
            var (verticalCount, horizontalCount, diagonalCount, totalCount) = logic.SearchWord(word);
            verticalOutput.Text = verticalCount.ToString();
            horizontalOutput.Text = horizontalCount.ToString();
            diagonalOutput.Text = diagonalCount.ToString();
            totalOutput.Text = totalCount.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
