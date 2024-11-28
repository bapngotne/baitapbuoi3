using System.Windows.Forms;

namespace baitapbuoi3
{
    public class MyForm : Form
    {
        private ListView listView;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox phoneTextBox;
        private Button addButton;

        public MyForm()
        {
            // Khởi tạo form
            this.Text = "ListView Demo";
            this.Size = new System.Drawing.Size(400, 300);

            // Khởi tạo ListView
            listView = new ListView();
            listView.Location = new System.Drawing.Point(12, 12);
            listView.Size = new System.Drawing.Size(360, 150);
            listView.View = View.Details;
            listView.Columns.Add("Last Name", 100);
            listView.Columns.Add("First Name", 100);
            listView.Columns.Add("Phone", 100);
            this.Controls.Add(listView);

            // Khởi tạo các TextBox và Button
            lastNameTextBox = new TextBox();
            lastNameTextBox.Location = new System.Drawing.Point(12, 180);
            lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(lastNameTextBox);

            firstNameTextBox = new TextBox();
            firstNameTextBox.Location = new System.Drawing.Point(136, 180);
            firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(firstNameTextBox);

            phoneTextBox = new TextBox();
            phoneTextBox.Location = new System.Drawing.Point(260, 180);
            phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(phoneTextBox);

            addButton = new Button();
            addButton.Location = new System.Drawing.Point(12, 212);
            addButton.Text = "Add";
            this.Controls.Add(addButton);
        }
    }
}

