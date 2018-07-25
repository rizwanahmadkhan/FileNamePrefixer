using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenamer
{
    public partial class Form1 : Form
    {
        #region Errors

        private const int INVALID_SORTING_PROPERTY = -2;

        #endregion

        #region Data Members

        string strFolderPath = string.Empty;
        FolderBrowserDialog fbdFolderBroweDialog;
        DialogResult drFolderBrowseDialogResult;
        string[] filesArray;
        FileInfo[] fileInfoArray;
        List<FileInfo> filesList;
        BindingList<FileInfo> bindlistfilesList = new BindingList<FileInfo>();
        DirectoryInfo directoryInfo;

        Comparison<FileInfo> comparisonFunc;

        const string SortPropertName = "Name";
        const string SortPropertDateCreated = "Date Created";
        const string SortPropertDateModified = "Date Modified";
        #endregion

        public Form1()
        {
            InitializeComponent();

            //Add options in file format and Sorting property and sorting type

            cmbFileFormat.Items.Add("--Select--");
            cmbFileFormat.Items.Add("mp4");
            cmbFileFormat.Items.Add("mp3");
            cmbFileFormat.Items.Add("avi");
            cmbFileFormat.SelectedIndex = 0;

            cmbSortProperty.Items.Add("--Select--");
            cmbSortProperty.Items.Add(SortPropertName);
            cmbSortProperty.Items.Add(SortPropertDateCreated);
            cmbSortProperty.Items.Add(SortPropertDateModified);
            cmbSortProperty.SelectedIndex = 0;

            cmbSortingType.Items.Add("--Select--");
            cmbSortingType.Items.Add("Ascending");
            cmbSortingType.Items.Add("Descending");
            cmbSortingType.SelectedIndex = 0;

            lstbFileNames.DataSource = bindlistfilesList;
            lstbFileNames.DisplayMember = "Name";

            txtSelectedFolderPath.TextChanged += TxtSelectedFolderPath_TextChanged;
            cmbSortProperty.SelectionChangeCommitted += CmbSortProperty_SelectionChangeCommitted;
            cmbSortingType.SelectionChangeCommitted += CmbSortProperty_SelectionChangeCommitted;

            comparisonFunc = new Comparison<FileInfo>(compareFile);
        }

        private void CmbSortingType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (bindlistfilesList.Count > 0)
            {
                filesList.Sort(comparisonFunc);

                if (cmbSortingType.SelectedText.ToUpper() == SortingType.Descending.ToString().ToUpper())
                {
                    filesList.Reverse();
                }

                lstbFileNames.DataSource = bindlistfilesList;
                lstbFileNames.DisplayMember = "Name";
            }
        }

        private void CmbSortProperty_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (bindlistfilesList.Count > 0)
            {
                filesList.Sort(comparisonFunc);

                if (cmbSortingType.SelectedText.ToUpper() == SortingType.Descending.ToString().ToUpper())
                {
                    filesList.Reverse();
                }
                //bindlistfilesList.Clear();
                bindlistfilesList = new BindingList<FileInfo>(filesList);
                lstbFileNames.DataSource = bindlistfilesList;
                lstbFileNames.DisplayMember = "Name";
            }
        }

        private void TxtSelectedFolderPath_TextChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void PopulateList()
        {
            if (Directory.Exists(strFolderPath) == true)
            {
                directoryInfo = new DirectoryInfo(strFolderPath);
                fileInfoArray = directoryInfo.GetFiles();
                //filesArray = Directory.GetFiles(strFolderPath);
                filesList = fileInfoArray.ToList();
                //templist.Sort(comparisonFunc);
                bindlistfilesList = new BindingList<FileInfo>(filesList);
                //filesList
                lstbFileNames.DataSource = bindlistfilesList;
                lstbFileNames.DisplayMember = "Name";
                //foreach(string file in filesArray)
                //{
                //    filesList.Add(new FileInfo(file));
                //    //lstbFileNames.DataSource = filesList;
                //}
            }
            else
            {
                tsslStatusLabel.Text = "Invalid Folder Path";
            }
        }

        private int compareFile(FileInfo x, FileInfo y)
        {
            if (cmbSortProperty.SelectedItem.ToString() == SortPropertName)
            {
                return string.Compare(x.Name, y.Name);
            }
            else if (cmbSortProperty.SelectedItem.ToString() == SortPropertDateCreated)
            {
                return DateTime.Compare(x.CreationTime, y.CreationTime);
            }
            else if (cmbSortProperty.SelectedItem.ToString() == SortPropertDateModified)
            {
                return DateTime.Compare(x.LastWriteTime, y.LastWriteTime);
            }
            else
            {
                return string.Compare(x.Name, y.Name);
            }
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fbdFolderBroweDialog = new FolderBrowserDialog();
            drFolderBrowseDialogResult = fbdFolderBroweDialog.ShowDialog();
            if (drFolderBrowseDialogResult == DialogResult.OK)
            {
                strFolderPath = fbdFolderBroweDialog.SelectedPath;
                txtSelectedFolderPath.Text = strFolderPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 1;

            foreach (FileInfo file in filesList)
            {
                string newName = file.DirectoryName + "\\" + counter.ToString("D3") + " - " + file.Name;
                File.Move(file.FullName, newName);
                counter++;
            }
            PopulateList();
        }
    }

    public enum FileFormat
    {
        mp4,
        mp3,
        avi,
    }

    public enum SortingProperty
    {
        Name,
        DateCreated,
        DateModified,
    }

    public enum SortingType
    {
        Ascending,
        Descending,
    }
}
