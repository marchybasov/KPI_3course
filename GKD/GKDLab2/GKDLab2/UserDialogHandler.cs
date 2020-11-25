using System.Windows.Forms;

namespace GKDLab2
{
    public static class UserDialogHandler
    {
        public static string GetFileName(string namePlaceholder, string userDialogTitle)
        {
            SaveFileDialog saveFileDialog1 = CreateFilterForTextFiles(namePlaceholder, userDialogTitle);
            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string tempFilePath = saveFileDialog1.FileName.ToString().TrimStart().TrimEnd();
                if (tempFilePath != string.Empty && tempFilePath != null)
                {
                    return tempFilePath;
                }
            }

            return null;
        }
        private static SaveFileDialog CreateFilterForTextFiles(string filenamePlaceholder, string userDialogTitle)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Txt File|*.txt";
            dialog.Title = userDialogTitle;
            dialog.FileName = filenamePlaceholder;
            return dialog;
        }


        public static string BrowseToFile(string fileNamePlaceholder, string userDialogTitle)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt file|*.txt";
            fileDialog.Title = userDialogTitle;
            fileDialog.FileName = fileNamePlaceholder;
            DialogResult res = fileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            else
            {
                return string.Empty;
            }
        }



    }
}
