using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Flight.ASP.NET
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             Panelfinal.Visible = Panelpricing.Visible = false;
            Labelemail.Visible = false;
            txtEmail.Visible = false;
            if (!Page.IsPostBack)
            {
                
                radlistgender.Items.Add(new ListItem("Mr"));
                radlistgender.Items.Add(new ListItem("Mm"));
                radlistgender.SelectedIndex = 0;

                cbocity.Items.Add(new ListItem("SElect your city ", ""));
                cbocity.Items.Add(new ListItem("Montreal", "300"));
                cbocity.Items.Add(new ListItem("Torento", "400"));
                cbocity.Items.Add(new ListItem("Vancover", "600"));
                cbocity.SelectedIndex = 0;

                listdist.Items.Add(new ListItem("Montreal", "-100"));
                listdist.Items.Add(new ListItem("NewYork", "100"));
                listdist.Items.Add(new ListItem("Torento", "-100"));
                listdist.Items.Add(new ListItem("Vancover", "100"));
                listdist.Items.Add(new ListItem("Baltimor", "200"));
                listdist.Items.Add(new ListItem("PhyladelPhy", "300"));
                listdist.Items.Add(new ListItem("Washangton DC", "400"));
              
                listdist.SelectedIndex = 0;

                radlisttrip.Items.Add(new ListItem("Simple", "1"));
                radlisttrip.Items.Add(new ListItem("Round", "1.5"));
                radlisttrip.SelectedIndex = 0;

                ListBoxfclass.Items.Add(new ListItem("Economie", "0"));
                ListBoxfclass.Items.Add(new ListItem("First Class", "250"));
                ListBoxfclass.Items.Add(new ListItem("VIP", "350"));
                ListBoxfclass.SelectedIndex = 0;

                chkboxlisservice.Items.Add(new ListItem("", "0"));
                chkboxlisservice.Items.Add(new ListItem("Extabagage ,", "50"));
                chkboxlisservice.Items.Add(new ListItem("Taxi ,", "70"));
                chkboxlisservice.Items.Add(new ListItem("Hote for l night", "200"));
                chkboxlisservice.SelectedIndex = 0;

            }
            if(cbocity.SelectedIndex > 0)
            {
                Panelpricing.Visible = true;
                ClculPrice();
            }
            

        }
        private void ClculPrice()
        {
            decimal baseprice = 0, disprice = 0, trpprice = 0, fclassprice = 0, servprice = 0, subtotal = 0,
                tax = 0, total = 0;
            String from = "", ditance = "", trip = "", fclass = "", service = "",dtime ="";
           // baseprice = Convert.ToDecimal(cbocity.SelectedItem.Value);
           // disprice = Convert.ToDecimal(listdist.SelectedItem.Value);
            trpprice = Convert.ToDecimal(radlisttrip.SelectedItem.Value);
             fclassprice = Convert.ToDecimal(ListBoxfclass.SelectedItem.Value);
            fclass = ListBoxfclass.SelectedItem.Text;
            foreach(ListItem item in cbocity.Items)
            {
                baseprice += (item.Selected) ? Convert.ToDecimal(item.Value) : 0;
                if (item.Selected)
                {
                    from += cbocity.SelectedIndex.ToString(item.Text);
                }

            }
            foreach(ListItem item in listdist.Items)
            {
                disprice += (item.Selected) ? Convert.ToDecimal(item.Value) : 0;
                if (item.Selected)
                {
                    ditance += listdist.SelectedIndex.ToString(item.Text);
                }

            }
            if (from == ditance)
            {
                litprice.Text = "<br><b>Please choice the oter distanation <b>" + "</br>";
            }
            else
            {


                foreach (ListItem item in chkboxlisservice.Items)
            {
                servprice += (item.Selected) ? Convert.ToDecimal(item.Value) : 0;
                if (item.Selected)
                {
                   service += chkboxlisservice.SelectedIndex.ToString(item.Text);
                }
               
               
            }
            if (chEmail.Checked)
            {
                Labelemail.Visible = true;
                txtEmail.Visible = true;
            }
            decimal mp = baseprice + disprice;
             
            subtotal = ((baseprice + disprice) * trpprice) + fclassprice + servprice;
            tax = (subtotal * 15) / 100;
            total = subtotal + tax;
            //from = cbocity.SelectedItem.Text;
            //ditance = listdist.SelectedItem.Text;
           
                dtime = txtdattime.Text;
                trip = radlisttrip.SelectedItem.Text;
            litprice.Text = "<br><b> Base price =<b>" +subtotal +"</br>";
            litprice.Text+= "<br><b> Taxe price =<b>" + tax + "</br>";
            litprice.Text += "<br><b> Total price =<b>" + total + "</br>";
            litprice.Text+= "<br><b> <h1> Detiel</h1><b>" +  "</br>";
            litprice.Text+= "<br><b> From city of<b>" +from+"to"+ditance+"at"+dtime+"Base price is="+mp+"</br>";
            litprice.Text += "<br><b> your trip is<b>" + trip + "for" + (trpprice*mp)+"$" + "and your class flight is" + fclass +"for"+fclassprice+"$ "+"</br>";
            litprice.Text += "<br><b> And your extra service are<b>" + service+"," + "for" + servprice + "$" +  "</br>";
                }

        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void chEticket_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void btncon_Click(object sender, EventArgs e)
        {
            if (btncon.Enabled)
            {
                Panelfinal.Visible = true;
            }
            decimal baseprice = 0, disprice = 0, trpprice = 0, fclassprice = 0, servprice = 0, subtotal = 0,
               tax = 0, total = 0;
            String from = "", ditance = "", trip = "", fclass = "", service = "";
            baseprice = Convert.ToDecimal(cbocity.SelectedItem.Value);
            disprice = Convert.ToDecimal(listdist.SelectedItem.Value);
            trpprice = Convert.ToDecimal(radlisttrip.SelectedItem.Value);
            fclassprice = Convert.ToDecimal(ListBoxfclass.SelectedItem.Value);

            fclass = ListBoxfclass.SelectedItem.Text;
            foreach (ListItem item in chkboxlisservice.Items)
            {
                servprice += (item.Selected) ? Convert.ToDecimal(item.Value) : 0;
                if (item.Selected)
                {
                    service += chkboxlisservice.SelectedIndex.ToString(item.Text);
                }


            }
            if (chEmail.Checked)
            {
                Labelemail.Visible = true;
                txtEmail.Visible = true;
            }
            decimal mp = baseprice + disprice;
            subtotal = ((baseprice + disprice) * trpprice) + fclassprice + servprice;
            tax = (subtotal * 15) / 100;
            total = subtotal + tax;
            from = cbocity.SelectedItem.Text;
            ditance = listdist.SelectedItem.Text;
            trip = radlisttrip.SelectedItem.Text;
            String gen = radlistgender.SelectedItem.Text;
            String nam = txtName.Text;
            String tea = txtEmail.Text;
            String dd = txtdattime.Text;
            litfinal.Text="<br><b>Dear<b>" + gen + nam + "Your ticket has been registered" + "for" + from + "to" +
                ditance +"at"+dd+"for total of"+total+"$" +"and will send you to your adderss"+tea+"</br>";
        }

        protected void txtdattime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}