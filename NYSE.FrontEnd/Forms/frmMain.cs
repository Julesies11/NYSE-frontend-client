using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NYSE.BusinessLayer;

namespace NYSE.FrontEnd
{
    public partial class frmMain : Form
    {
        // declare the daily price object
        //public static NYSE nyse = new NYSE();

        public frmMain()
        {

            // init the main menu
            try {

                InitializeComponent();

                // set menu items
                InitMenu();

                // Set the start position of the form to the center of the screen.
                this.StartPosition = FormStartPosition.CenterScreen;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitMenu() {

            // set the menu strip
            try { 

                // init menu
                MenuStrip menu = this.menuStripMain;
                Font menuFont = new Font("Georgia", 14);
                menu.BackColor = Color.CornflowerBlue;
                menu.ForeColor = Color.Black;
                menu.Text = "Main Menu";
                menu.Font = menuFont;

                // set the menu items
                DoMenuItem(this, menu, "list");
                DoMenuItem(this, menu, "add");
                DoMenuItem(this, menu, "edit");
                DoMenuItem(this, menu, "external");
                DoMenuItem(this, menu, "info");
                DoMenuItem(this, menu, "exit");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void HideMain()
        {
            // hide frmMain. used when another form is opened
            this.Hide();
        }

        public void ShowMain()
        {
            // show frmMain. used when another form is closed
            this.Show();
        }


        private void menuItemAdd_clicked(object sender, EventArgs e)
        {
            // load form to add new price record to database

            try
            { 

                // close all open forms except main menu
                CloseOpenForms();

                // hide the main menu
                HideMain();

                // open appropriate form
                frmAddRecord frmadd = new frmAddRecord();
                frmadd.Owner = this;
                frmadd.Show();

                // clear the menu
                var menu = (MenuStrip)frmadd.menuStripMain;
                menu.Items.Clear();

                // set the menu items
                DoMenuItem(frmadd, menu, "back");
                DoMenuItem(frmadd, menu, "list");
                DoMenuItem(frmadd, menu, "edit");
                DoMenuItem(frmadd, menu, "external");
                DoMenuItem(frmadd, menu, "info");
                DoMenuItem(frmadd, menu, "exit");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void menuItemList_clicked(object sender, EventArgs e)
        {
            // load form to display list of price records in the database

            try
            { 

                // close all open forms except main menu
                CloseOpenForms();

                // hide the main menu
                HideMain();

                // open appropriate form
                frmLoadFromDatabase frmload = new frmLoadFromDatabase();
                frmload.Owner = this;
                frmload.Show();

                // clear the menu
                var menu = (MenuStrip)frmload.menuStripMain;
                menu.Items.Clear();

                // set the menu items
                DoMenuItem(frmload, menu, "back");
                DoMenuItem(frmload, menu, "add");
                DoMenuItem(frmload, menu, "edit");
                DoMenuItem(frmload, menu, "external");
                DoMenuItem(frmload, menu, "info");
                DoMenuItem(frmload, menu, "exit");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void CloseOpenForms() {
            // closes all open forms except main menu

            try { 

                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "frmMain")
                        Application.OpenForms[i].Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void menuItemEdit_clicked(object sender, EventArgs e)
        {
            // load form to edit or delete price record

            try
            {

                // close all open forms except main menu
                CloseOpenForms();

                // hide the main menu
                HideMain();

                // open appropriate form
                frmEditRecord frmEdit = new frmEditRecord();
                frmEdit.Owner = this;
                frmEdit.Show();

                // clear the menu
                var menu = (MenuStrip)frmEdit.menuStripMain;
                menu.Items.Clear();

                // set the menu items
                DoMenuItem(frmEdit, menu, "back");
                DoMenuItem(frmEdit, menu, "list");
                DoMenuItem(frmEdit, menu, "add");
                DoMenuItem(frmEdit, menu, "external");
                DoMenuItem(frmEdit, menu, "info");
                DoMenuItem(frmEdit, menu, "exit");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemExternalAPI_clicked(object sender, EventArgs e)
        {
            // load ExternalAPI form

            try
            {

                // close all open forms except main menu
                CloseOpenForms();

                // hide the main menu
                HideMain();

                // open appropriate form
                frmExternalAPI frmExternalAPI = new frmExternalAPI();
                frmExternalAPI.Owner = this;
                frmExternalAPI.Show();

                // clear the menu
                var menu = (MenuStrip)frmExternalAPI.menuStripMain;
                menu.Items.Clear();

                // set the menu items
                DoMenuItem(frmExternalAPI, menu, "back");
                DoMenuItem(frmExternalAPI, menu, "list");
                DoMenuItem(frmExternalAPI, menu, "add");
                DoMenuItem(frmExternalAPI, menu, "edit");

                DoMenuItem(frmExternalAPI, menu, "info");
                DoMenuItem(frmExternalAPI, menu, "exit");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemInfo_clicked(object sender, EventArgs e)
        {
            // load server info form

            try
            {

                // close all open forms except main menu
                CloseOpenForms();

                // hide the main menu
                HideMain();

                // open appropriate form
                frmServerInfo frmServerInfo = new frmServerInfo();
                frmServerInfo.Owner = this;
                frmServerInfo.Show();

                // clear the menu
                var menu = (MenuStrip)frmServerInfo.menuStripMain;
                menu.Items.Clear();

                // set the menu items
                DoMenuItem(frmServerInfo, menu, "back");
                DoMenuItem(frmServerInfo, menu, "list");
                DoMenuItem(frmServerInfo, menu, "add");
                DoMenuItem(frmServerInfo, menu, "edit");
                DoMenuItem(frmServerInfo, menu, "external");

                DoMenuItem(frmServerInfo, menu, "exit");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DoMenuItem(Form frm, MenuStrip menu, string item) {

            // function to add menu items to menu
            // pass in the form, the menu and the name of the menu item

            try {

                switch (item)
                {
                    case "back":
                        ToolStripMenuItem backMenu = new ToolStripMenuItem("backMenu");
                        backMenu.Text = "<< &Main Menu";
                        backMenu.ToolTipText = "Go back to main menu";
                        menu.Items.Add(backMenu);
                        EventHandler backEvent = (s, ev) => menuItemBack_clicked(s, ev, frm);
                        backMenu.Click += backEvent;
                        break;
                    case "list":
                        ToolStripMenuItem listMenu = new ToolStripMenuItem("listMenu");
                        listMenu.Text = "&List All Daily Prices";
                        listMenu.ToolTipText = "List All Daily Prices in the database";
                        menu.Items.Add(listMenu);
                        listMenu.Click += new System.EventHandler(this.menuItemList_clicked);
                        break;
                    case "add":
                        ToolStripMenuItem addMenu = new ToolStripMenuItem("addMenu");
                        addMenu.Text = "&Add New Daily Price";
                        addMenu.ToolTipText = "Add New Daily Price to database";
                        menu.Items.Add(addMenu);
                        addMenu.Click += new System.EventHandler(this.menuItemAdd_clicked);
                        break;
                    case "edit":
                        ToolStripMenuItem editMenu = new ToolStripMenuItem("editMenu");
                        editMenu.Text = "&Edit/Delete existing Daily Price";
                        editMenu.ToolTipText = "Edit/Delete an existing Daily Price in the database";
                        menu.Items.Add(editMenu);
                        editMenu.Click += new System.EventHandler(this.menuItemEdit_clicked);
                        break;
                    case "external":
                        ToolStripMenuItem externalMenu = new ToolStripMenuItem("externalMenu");
                        externalMenu.Text = "E&xternal API";
                        externalMenu.ToolTipText = "External API";
                        menu.Items.Add(externalMenu);
                        externalMenu.Click += new System.EventHandler(this.menuItemExternalAPI_clicked);
                        break;
                    case "info":
                        ToolStripMenuItem infoMenu = new ToolStripMenuItem("infoMenu");
                        infoMenu.Text = "&Server Info";
                        infoMenu.ToolTipText = "Server Info";
                        menu.Items.Add(infoMenu);
                        infoMenu.Click += new System.EventHandler(this.menuItemInfo_clicked);
                        break;
                    case "exit":
                        ToolStripMenuItem exitMenu = new ToolStripMenuItem("exitMenu");
                        exitMenu.Text = "Exi&t App";
                        exitMenu.ToolTipText = "Exit the Application";
                        menu.Items.Add(exitMenu);
                        exitMenu.Click += new System.EventHandler(this.menuItemExit_clicked);
                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void menuItemExit_clicked(object sender, EventArgs e)
        {
            // exit the application

            try {

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void menuItemBack_clicked(object sender, EventArgs e, Form frm)
        {
            // close the form to go back

            try { 

                frm.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
