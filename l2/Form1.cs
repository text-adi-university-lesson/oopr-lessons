using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using l2.Tools;

namespace l2
{
    // 13 - 14 number 
    public partial class Form1 : MaterialForm
    {
        Payment payment;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            payment = new Payment();
        }

        private void materialButtonAddNewClient_Click(object sender, EventArgs e)
        {
            string name = materialTextBoxName.Text;
            string address = materialTextBoxAddress.Text;
            
            Client client = new Client(name:name, address:address);

            var paymentClient = payment.Clients;
            paymentClient.Add(client);


            materialComboBoxClients.Items.Clear();
            materialComboBox2.Items.Clear();
            materialComboBoxClients.Items.AddRange(paymentClient.ToArray());
            materialComboBox2.Items.AddRange(paymentClient.ToArray());


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string number = materialTextBoxInputCreditCard.Text;
            CreditCard card = new CreditCard(number: number);

            var paymentClient = payment.CreditCards;
            paymentClient.Add(card);


            materialComboBox1.Items.Clear();
            materialComboBox1.Items.AddRange(paymentClient.ToArray());


            materialComboBoxClientListCards.Items.Clear();
            materialComboBoxClientListCards.Items.AddRange(paymentClient.ToArray());


        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string name = materialTextBoxBancAccount.Text;
            BankAccount bankAccount = new BankAccount(name);
            var paymentClient = payment.BankAccounts;
            paymentClient.Add(bankAccount);


            materialComboBoxClientBankAccountList.Items.Clear();
            materialComboBoxClientBankAccountList.Items.AddRange(paymentClient.ToArray());
        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            var client = ((Client)((MaterialComboBox)sender).SelectedItem);
            if (client is null) return;
            materialTextBox3.Text = client.Address;
            materialComboBoxClientListCards.SelectedItem = client.Card;
            materialComboBoxClientBankAccountList.SelectedItem = client.BankAccount;


        }

        private void materialComboBoxClientListCards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButtonUpdateClient_Click(object sender, EventArgs e)
        {
            var client = (Client)(materialComboBox2.SelectedItem);
            client.Address = materialTextBox3.Text;
            client.Card = (CreditCard)materialComboBoxClientListCards.SelectedItem;
            client.BankAccount = (BankAccount)materialComboBoxClientBankAccountList.SelectedItem;
        }
    }
}
