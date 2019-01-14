using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace WF_CoffeeManage
{
    public partial class ViewTables : UserControl
    {
        //private static ViewTables _instance;
        //public static ViewTables Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new ViewTables();
        //        return _instance;
        //    }
        //}
        public ViewTables(int type)
        {

            this.type = type;
            InitializeComponent();
            SetListTable(Table, this.type);
            this.cbTable.SelectedIndex = 0;


            //
            //SetAccounts(Accounts);
            //cbSearchAttr.DataSource = Accounts;
        }

        private void CountRow()
        {
            int count = dtgvTable.RowCount - 1;
            lbRows.Text = "STATUS: There are " + count.ToString() + " record(s) found in database";
        }

        private int type;
        private List<string> Table = new List<string>();

        private List<String> Customers = new List<string>();
        private List<String> Drinks = new List<string>();
        private List<String> Elements = new List<string>();
        private List<String> Employees = new List<string>();
        private List<String> ImportBills = new List<string>();
        private List<String> ExportBills = new List<string>();
        private List<String> Jobs = new List<string>();
        private List<String> Suppliers = new List<string>();
        private List<String> Accounts = new List<string>();

        private EmployeeBAL Employee = new EmployeeBAL();
        private DrinkBAL Drink = new DrinkBAL();
        private CustomerBAL Customer = new CustomerBAL();
        private ElementBAL Element = new ElementBAL();
        private SupplierBAL Supplier = new SupplierBAL();
        private JobBAL Job = new JobBAL();
        private AccountBAL Account = new AccountBAL();
        private ImportBillBAL ImportBill = new ImportBillBAL();
        private ExportBillBAL ExportBill = new ExportBillBAL();

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cbTable.SelectedItem.ToString();

            switch (category)
            {
                case "Customers":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Customers, Customer.GetCustomerList());
                        break;
                    }
                case "Drinks":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Drinks, Drink.GetDrinkList());
                        break;
                    }
                case "Elements":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Elements, Element.GetElementList());
                        break;
                    }
                case "Employees":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Employees, Employee.GetEmployeeList());
                        break;
                    }
                case "ImportBills":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, ImportBills, ImportBill.GetAllBills());
                        break;
                    }
                case "ExportBills":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, ExportBills, ExportBill.GetAllBills());
                        break;
                    }
                case "Jobs":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Jobs, Job.GetJobList());
                        break;
                    }
                case "Suppliers":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Suppliers, Supplier.GetSupplierList());
                        break;
                    }
                case "Accounts":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Accounts, Account.GetAccountList());
                        break;
                    }
            }
        }

        private void DisplayTable(ComboBox cb, DataGridView dtgv, List<string> list, DataSet ds)
        {
            cb.DataSource = null;
            dtgv.DataSource = null;
            dtgv.DataSource = ds.Tables[0].DefaultView;
            cb.DataSource = list;
            CountRow();
        }

        private void SetCustomers(List<String> Cus)
        {
            Cus.Add("Mã Khách Hàng");
            Cus.Add("Họ Tên");
            Cus.Add("Loại");
        }

        private void SetDrinks(List<String> Dri)
        {
            Dri.Add("Mã Thức Uống");
            Dri.Add("Tên Thức Uống");
            Dri.Add("Mục");
            Dri.Add("Price");
        }

        private void SetElements(List<String> Ele)
        {
            Ele.Add("Mã Nguyên Liệu");
            Ele.Add("Tên Nguyên Liệu");
            Ele.Add("Đơn Vị");
            Ele.Add("Giá");
        }

        private void SetEmployees(List<String> Emp)
        {
            Emp.Add("Mã Nhân Viên");
            Emp.Add("Họ Tên");
            Emp.Add("Tuổi");
            Emp.Add("Giới Tính");
            Emp.Add("Số Điện Thoại");
            Emp.Add("Công Việc");
        }

        private void SetBills(List<String> ImpBills, List<String> ExpBills)
        {
            ImpBills.Add("Serial");
            ImpBills.Add("Nhà Cung Cấp");
            ImpBills.Add("Nhân Viên");

            ExpBills.Add("Serial");
            ExpBills.Add("Nhân Viên");
            ExpBills.Add("Khách Hàng");
        }

        private void SetJobs(List<String> Jobs)
        {
            Jobs.Add("Mã Công Việc");
            Jobs.Add("Tên Công Việc");
        }

        private void SetSuplliers(List<String> Sups)
        {
            Sups.Add("Mã Nhà Cung Cấp");
            Sups.Add("Tên Nhà Cung Cấp");
            Sups.Add("Địa Chỉ");
        }

        private void SetAccounts(List<String> Accs)
        {
            Accs.Add("UserName");
            Accs.Add("Password");
            Accs.Add("Loại");
        }

        private void SetAttribute()
        {
            SetCustomers(Customers);
            SetDrinks(Drinks);
            SetElements(Elements);
            SetEmployees(Employees);
            SetBills(ImportBills, ExportBills);
            SetJobs(Jobs);
            SetSuplliers(Suppliers);
            SetAccounts(Accounts);
        }

        private void SetListTable(List<string> Table, int type)
        {
            if (type == 0)
            {
                Table.Add("Customers");
                Table.Add("Drinks");
                Table.Add("Elements");
                Table.Add("ImportBills");
                Table.Add("ExportBills");
                Table.Add("Suppliers");
            }
            else //==1
            {
                Table.Add("Accounts");
                Table.Add("Customers");
                Table.Add("Drinks");
                Table.Add("Employees");
                Table.Add("Suppliers");
                Table.Add("Elements");
                Table.Add("ImportBills");
                Table.Add("ExportBills");
                Table.Add("Suppliers");
                Table.Add("Jobs");
            }
            cbTable.DataSource = Table;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ViewTables_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SetAttribute();
            SetListTable(Table, this.type);
            this.cbTable.SelectedIndex = 0;
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchValue.Text == "")
            {
                SelectedType();
            }
            else
            {
                string property = cbSearchAttr.SelectedValue.ToString();
                string value = txtSearchValue.Text;
                string TableName = cbTable.SelectedItem.ToString();
                switch (TableName)
                {
                    case "Customers":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Customers,
                            Customer.GetCustomerFromProperty(property, value));
                        break;
                    }
                    case "Drinks":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Drinks, Drink.GetDrinkFromProperty(property, value));
                        break;
                    }
                    case "Elements":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Elements,
                            Element.GetElementFromProperty(property, value));
                        break;
                    }
                    case "Employees":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Employees,
                            Employee.GetEmployeeFromProperty(property, value));
                        break;
                    }
                    case "ImportBills":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, ImportBills,
                            ImportBill.GetImportBillFromProperty(property, value));
                        break;
                    }
                    case "ExportBills":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, ExportBills,
                            ExportBill.GetEmployeeFromProperty(property, value));
                        break;
                    }
                    case "Jobs":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Jobs, Job.GetJobFromProperty(property, value));
                        break;
                    }
                    case "Suppliers":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Suppliers,
                            Supplier.GetSupplierFromProperty(property, value));
                        break;
                    }
                    case "Accounts":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Accounts,
                            Account.GetAccountFromProperty(property, value));
                        break;
                    }
                }
            }
        }

        private void SelectedType()
        {
            string category = cbTable.SelectedItem.ToString();

            switch (category)
            {
                case "Customers":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Customers, Customer.GetCustomerList());
                        break;
                    }
                case "Drinks":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Drinks, Drink.GetDrinkList());
                        break;
                    }
                case "Elements":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Elements, Element.GetElementList());
                        break;
                    }
                case "Employees":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Employees, Employee.GetEmployeeList());
                        break;
                    }
                case "ImportBills":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, ImportBills, ImportBill.GetAllBills());
                        break;
                    }
                case "ExportBills":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, ExportBills, ExportBill.GetAllBills());
                        break;
                    }
                case "Jobs":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Jobs, Job.GetJobList());
                        break;
                    }
                case "Suppliers":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Suppliers, Supplier.GetSupplierList());
                        break;
                    }
                case "Accounts":
                    {
                        DisplayTable(cbSearchAttr, dtgvTable, Accounts, Account.GetAccountList());
                        break;
                    }
            }
        }

        private void cbSearchAttr_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
