﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaneshLogistics.AppCode;

namespace GST_Billing
{
    public partial class CustomerDetails : Form
    {
        BaseModel baseModel = BaseModel.Instance;
        SqliteDb m1 = new SqliteDb();

        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
        }

        void CustomerDetails_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            //this.Hide();
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCode.Text = baseModel.stateCodes[cbState.Text];
        }

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            bool name = !String.IsNullOrEmpty(tbName.Text) && !String.IsNullOrWhiteSpace(tbName.Text) &&
                        !String.IsNullOrEmpty(tbShipName.Text) && !String.IsNullOrWhiteSpace(tbShipName.Text);
            bool address = !String.IsNullOrEmpty(tbAddress.Text) && !String.IsNullOrWhiteSpace(tbAddress.Text) &&
                           !String.IsNullOrEmpty(tbShipAddress.Text) && !String.IsNullOrWhiteSpace(tbShipAddress.Text);
            bool contact = !String.IsNullOrEmpty(tbContact.Text) && !String.IsNullOrWhiteSpace(tbContact.Text) &&
                           !String.IsNullOrEmpty(tbShipContact.Text) && !String.IsNullOrWhiteSpace(tbShipContact.Text);
            bool gstin = !String.IsNullOrEmpty(tbGstin.Text) && !String.IsNullOrWhiteSpace(tbGstin.Text) &&
                         !String.IsNullOrEmpty(tbShipGstin.Text) && !String.IsNullOrWhiteSpace(tbShipGstin.Text);
            bool state = !String.IsNullOrEmpty(cbState.Text) && !String.IsNullOrWhiteSpace(cbState.Text) &&
                         !String.IsNullOrEmpty(cbShipState.Text) && !String.IsNullOrWhiteSpace(cbShipState.Text);
            bool code = !String.IsNullOrEmpty(tbCode.Text) && !String.IsNullOrWhiteSpace(tbCode.Text) &&
                        !String.IsNullOrEmpty(tbShipCode.Text) && !String.IsNullOrWhiteSpace(tbShipCode.Text);

            if (name && address && contact && gstin && state && code && tbGstin.Text.Length == 15 && tbShipGstin.Text.Length == 15)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }

            if (cbBillShip.Checked)
            {
                syncBillingAndShipping();
            }
        }

        private void tbCode_LeaveFocus(object sender, EventArgs e)
        {
            if (cbBillShip.Checked)
            {
                int code = !String.IsNullOrEmpty(tbCode.Text) ? int.Parse(tbCode.Text) : 1;
                string codeStr = String.Format("{0:D2}", code);
                if (code > 0 && code < 37)
                {
                    string state = baseModel.stateCodes.FirstOrDefault(x => x.Value == codeStr).Key;
                    cbState.SelectedIndex = cbState.FindStringExact(state);
                }
                else
                {
                    MessageBox.Show("State code must be between 1 and 36.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbState.SelectedIndex = 1;
                }

                syncBillingAndShipping();
            }
            else
            {
                int code = !String.IsNullOrEmpty(tbShipCode.Text) ? int.Parse(tbShipCode.Text) : 1;
                string codeStr = String.Format("{0:D2}", code);
                if (code > 0 && code < 37)
                {
                    string state = baseModel.stateCodes.FirstOrDefault(x => x.Value == codeStr).Key;
                    cbShipState.SelectedIndex = cbShipState.FindStringExact(state);
                }
                else
                {
                    MessageBox.Show("State code must be between 1 and 36.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbShipState.SelectedIndex = 1;
                }
            }
        }

        private void tbCode_Click(object sender, EventArgs e)
        {
            string name = ((TextBox)sender).Name;
            if (name == "tbCode")
                tbCode.SelectAll();
            else
                tbShipCode.SelectAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This is not yet available!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            try
            {
                DataSet ds = customerExists(tbName.Text);
                int NoOfRows = 0;
                string sqlstr;
                if (ds != null)
                {
                    DialogResult result = MessageBox.Show("Do you want to update existing information?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        sqlstr = "UPDATE customerDetails set custname='" + tbName.Text + "', custaddress='" + tbAddress.Text + "', custstate='" + cbState.Text + 
                                  "', custcode='" + tbCode.Text + "', custgstin='" + tbGstin.Text + "', custemail='" + tbEmail.Text + 
                                  "', custphoneNumber='" + tbContact.Text + "', shipname='" + tbShipName.Text + "', shipaddress='" + tbShipAddress.Text + 
                                  "', shipemail='" + tbShipEmail.Text + "', shipphoneNumber='" + tbShipContact.Text + "', shipstate='" + cbShipState.Text + 
                                  "', shipcode='" + tbShipCode.Text + "', shipgstin='" + tbShipGstin.Text + "' where custname='" + tbName.Text + "'";
                        NoOfRows = m1.Ins_Upd_Del(sqlstr);
                    }
                }
                else
                {
                    sqlstr = "INSERT INTO customerDetails(custname, custaddress, custstate, custcode, custgstin, custemail, custphoneNumber, " +
                             "shipname, shipaddress, shipstate, shipcode, shipgstin, shipemail, shipphoneNumber)" +
                             "VALUES('" + tbName.Text + "', '" + tbAddress.Text + "', '" + cbState.Text + "','" + tbCode.Text + "', '" + tbGstin.Text + "', '" + tbEmail.Text + "', '" + tbContact.Text + "', '"
                                        + tbShipName.Text + "', '" + tbShipAddress.Text + "', '" + cbShipState.Text + "','" + tbShipCode.Text + "', '" + tbShipGstin.Text + "', '" + tbShipEmail.Text + "', '" + tbShipContact.Text + "')";
                    NoOfRows = m1.Ins_Upd_Del(sqlstr);
                }
                if (NoOfRows > 0)
                {
                    MessageBox.Show("Details saved successfully!", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Failed to save details!", "Information", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error :" + e1.Message);
            }

            //Invoice invoice = new Invoice();
            //invoice.Show();
            //this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = customerExists(tbName.Text);
                if (ds != null)
                {
                    tbAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["custaddress"]);
                    tbEmail.Text = Convert.ToString(ds.Tables[0].Rows[0]["custemail"]);
                    tbContact.Text = Convert.ToString(ds.Tables[0].Rows[0]["custphoneNumber"]);
                    tbGstin.Text = Convert.ToString(ds.Tables[0].Rows[0]["custgstin"]);
                    cbState.Text = Convert.ToString(ds.Tables[0].Rows[0]["custstate"]);
                    tbCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["custcode"]);
                    fillShippingDetailsFromDB(ds);

                }
                else
                {
                    MessageBox.Show("No records found", "Information", MessageBoxButtons.OK);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error :" + e1.Message);
            }
        }

        private void cbBillShip_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBillShip.Checked)
            {
                gbShipping.Enabled = false;
                syncBillingAndShipping();
            }
            else
            {
                gbShipping.Enabled = true;
                updateShippingDetailsFromDB();
            }

        }

        private void updateShippingDetailsFromDB()
        {
            DataSet ds = customerExists(tbName.Text);
            if(ds != null)
            {
                fillShippingDetailsFromDB(ds);
            }
        }

        private void fillShippingDetailsFromDB(DataSet ds)
        {
            tbShipName.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipname"]);
            tbShipAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipaddress"]);
            tbShipEmail.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipemail"]);
            tbShipContact.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipphoneNumber"]);
            tbShipGstin.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipgstin"]);
            cbShipState.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipstate"]);
            tbShipCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipcode"]);
        }

        private void syncBillingAndShipping()
        {
            tbShipName.Text = tbName.Text;
            tbShipAddress.Text = tbAddress.Text;
            tbShipContact.Text = tbContact.Text;
            tbShipEmail.Text = tbEmail.Text;
            tbShipGstin.Text = tbGstin.Text;
            cbShipState.Text = cbState.Text;
            tbShipCode.Text = tbCode.Text;
        }

        private void cbShipState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = baseModel.ToPascalCase(cbShipState.Text);
            tbShipCode.Text = baseModel.stateCodes[state];
        }

        private DataSet customerExists(string name)
        {
            string sqlstr = "SELECT * FROM customerDetails WHERE custname ='" + name + "'";
            DataSet ds = m1.selectData(sqlstr);
            if (ds.Tables[0].Rows.Count > 0)
                return ds;
            return null;
        }
    }
}
