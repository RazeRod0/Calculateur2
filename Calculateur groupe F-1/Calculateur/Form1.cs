using System;
using System.Formats.Asn1;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculateur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string obtBin(int number)
        {
            return Convert.ToString(number, 2);
        }
        private bool IPvalidation(string ip)
        {
            string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                             @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                             @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                             @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            return Regex.IsMatch(ip, pattern);
        }

        private bool MaskValidation(string mask)
        {
            string pattern = @"^(255|254|252|248|240|224|192|128|0)\." +
                             @"(255|254|252|248|240|224|192|128|0)\." +
                             @"(255|254|252|248|240|224|192|128|0)\." +
                             @"(255|254|252|248|240|224|192|128|0)$";
            return Regex.IsMatch(mask, pattern);
        }

        private void DecimalIP1_textChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                int oct1;
                if (int.TryParse(txtBox.Text, out oct1))
                {
                    string bin = obtBin(oct1);
                    BinaireIP1.Text = bin;
                }
                else
                {
                    BinaireIP1.Text = "Invalide";
                }
            }
            else
            {
                BinaireIP1.Text = "";
            }
        }

        private void DecimalIP2_textChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                int oct1;
                if (int.TryParse(txtBox.Text, out oct1))
                {
                    string bin = obtBin(oct1);
                    BinaireIP2.Text = bin;
                }
                else
                {
                    BinaireIP2.Text = "Invalid";
                }
            }
            else
            {
                BinaireIP2.Text = "";
            }
        }

        private void DecimalIP3_textChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                int oct1;
                if (int.TryParse(txtBox.Text, out oct1))
                {
                    string bin = obtBin(oct1);
                    BinaireIP3.Text = bin;
                }
                else
                {
                    BinaireIP3.Text = "Invalid";
                }
            }
            else
            {
                BinaireIP3.Text = "";
            }
        }

        private void DecimalIP4_textChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                int oct1;
                if (int.TryParse(txtBox.Text, out oct1))
                {
                    string bin = obtBin(oct1);
                    BinaireIP4.Text = bin;
                }
                else
                {
                    BinaireIP4.Text = "Invalid";
                }
            }
            else
            {
                BinaireIP4.Text = "";
            }
        }

        private void CIDR_textChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            string text = txtBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                int cidr;
                if (int.TryParse(text, out cidr))
                {
                    string[] masks = CIDRToMask(cidr);
                    Mask1.Text = masks[0];
                    Mask2.Text = masks[1];
                    Mask3.Text = masks[2];
                    Mask4.Text = masks[3];
                    return;
                }
            }
            Mask1.Text = "";
            Mask2.Text = "";
            Mask3.Text = "";
            Mask4.Text = "";
        }

        private void Mask_textChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Mask1.Text) &&
                !string.IsNullOrEmpty(Mask2.Text) &&
                !string.IsNullOrEmpty(Mask3.Text) &&
                !string.IsNullOrEmpty(Mask4.Text))
            {
                int mask1, mask2, mask3, mask4;
                if (int.TryParse(Mask1.Text, out mask1) &&
                    int.TryParse(Mask2.Text, out mask2) &&
                    int.TryParse(Mask3.Text, out mask3) &&
                    int.TryParse(Mask4.Text, out mask4))
                {
                    int cidr = MaskToCIDR(mask1, mask2, mask3, mask4);
                    CIDR.Text = cidr.ToString();
                }
            }
        }
        private string[] CIDRToMask(int cidr)
        {
            int networkBits = cidr;
            int octet1 = (networkBits >= 8) ? 255 : (int)(Math.Pow(2, networkBits) - 1) << (8 - networkBits);
            networkBits = (networkBits >= 8) ? networkBits - 8 : 0;
            int octet2 = (networkBits >= 8) ? 255 : (networkBits > 0) ? (int)(Math.Pow(2, networkBits) - 1) << (8 - networkBits) : 0;
            networkBits = (networkBits >= 8) ? networkBits - 8 : 0;
            int octet3 = (networkBits >= 8) ? 255 : (networkBits > 0) ? (int)(Math.Pow(2, networkBits) - 1) << (8 - networkBits) : 0;
            networkBits = (networkBits >= 8) ? networkBits - 8 : 0;
            int octet4 = (networkBits >= 8) ? 255 : (networkBits > 0) ? (int)(Math.Pow(2, networkBits) - 1) << (8 - networkBits) : 0;

            return new string[] { octet1.ToString(), octet2.ToString(), octet3.ToString(), octet4.ToString() };
        }

        private int MaskToCIDR(int mask1, int mask2, int mask3, int mask4)
        {
            string binaryMask = Convert.ToString(mask1, 2).PadLeft(8, '0') +
                                Convert.ToString(mask2, 2).PadLeft(8, '0') +
                                Convert.ToString(mask3, 2).PadLeft(8, '0') +
                                Convert.ToString(mask4, 2).PadLeft(8, '0');

            int networkBits = 0;
            foreach (char bit in binaryMask)
            {
                if (bit == '1')
                {
                    networkBits++;
                }
                else
                {
                    break;
                }
            }
            return networkBits;
        }
        private bool ValidationClasse(string ipClass, int mask1, int mask2, int mask3, int mask4)
        {
            if (ipClass == "A")
            {
                return (mask1 == 255 && mask2 >= 0 && mask2 <= 255 && mask3 >= 0 && mask3 <= 255 && mask4 >= 0 && mask4 <= 255);
            }
            else if (ipClass == "B")
            {
                return (mask1 == 255 && mask2 == 255 && mask3 >= 0 && mask3 <= 255 && mask4 >= 0 && mask4 <= 255);
            }
            else if (ipClass == "C")
            {
                return (mask1 == 255 && mask2 == 255 && mask3 == 255 && mask4 >= 0 && mask4 <= 255);
            }
            else
            {
                return false;
            }
        }
        private void BoutonCalcul_Click(object sender, EventArgs e)
        {
            string ipAddress = $"{DecimalIP1.Text}.{DecimalIP2.Text}.{DecimalIP3.Text}.{DecimalIP4.Text}";
            string subnetMask = $"{Mask1.Text}.{Mask2.Text}.{Mask3.Text}.{Mask4.Text}";

            if (!IPvalidation(ipAddress))
            {
                MessageBox.Show("Adresse IP invalide.");
                return;
            }

            if (!MaskValidation(subnetMask))
            {
                MessageBox.Show("Masque de sous-réseau invalide.");
                return;
            }

            int octet1, octet2, octet3, octet4, mask1, mask2, mask3, mask4;
            if (int.TryParse(DecimalIP1.Text, out octet1) &&
                int.TryParse(DecimalIP2.Text, out octet2) &&
                int.TryParse(DecimalIP3.Text, out octet3) &&
                int.TryParse(DecimalIP4.Text, out octet4) &&
                int.TryParse(Mask1.Text, out mask1) &&
                int.TryParse(Mask2.Text, out mask2) &&
                int.TryParse(Mask3.Text, out mask3) &&
                int.TryParse(Mask4.Text, out mask4))
            {
                string ipClass = CalculIPClass(octet1);

                if (!ValidationClasse(ipClass, mask1, mask2, mask3, mask4))
                {
                    MessageBox.Show("Le masque de sous-réseau saisi n'est pas valide pour la classe d'adresse IP.");
                    return;
                }

                string networkAddress = CalculNetworkAddresse(octet1, octet2, octet3, octet4, mask1, mask2, mask3, mask4);
                string broadcastAddress = CalculBroadcastAddresse(octet1, octet2, octet3, octet4, mask1, mask2, mask3, mask4);
                string[] firstAndLastIP = Calcul_FL_IP(networkAddress, broadcastAddress);

                Classe.Text = ipClass;
                string[] networkAddressParts = networkAddress.Split('.');
                ReseauIP1.Text = networkAddressParts[0];
                ReseauIP2.Text = networkAddressParts[1];
                ReseauIP3.Text = networkAddressParts[2];
                ReseauIP4.Text = networkAddressParts[3];

                string[] broadcastAddressParts = broadcastAddress.Split('.');
                BroadCastIP1.Text = broadcastAddressParts[0];
                BroadCastIP2.Text = broadcastAddressParts[1];
                BroadCastIP3.Text = broadcastAddressParts[2];
                BroadCastIP4.Text = broadcastAddressParts[3];

                string[] firstIPParts = firstAndLastIP[0].Split('.');
                FIP1.Text = firstIPParts[0];
                FIP2.Text = firstIPParts[1];
                FIP3.Text = firstIPParts[2];
                FIP4.Text = firstIPParts[3];

                string[] lastIPParts = firstAndLastIP[1].Split('.');
                LIP1.Text = lastIPParts[0];
                LIP2.Text = lastIPParts[1];
                LIP3.Text = lastIPParts[2];
                LIP4.Text = lastIPParts[3];

                int totalIPs = CalculTotalIP(mask1, mask2, mask3, mask4);
                int usableIPs = totalIPs - 2;

                NbIP.Text = totalIPs.ToString();
                NbMac.Text = usableIPs.ToString();
            }
            else
            {
                MessageBox.Show("Veuillez entrer des valeurs valides pour l'adresse IP et le masque de sous-réseau.");
            }
        }

        private string CalculIPClass(int octet1)
        {
            if (octet1 >= 1 && octet1 <= 126)
                return "A";
            else if (octet1 >= 128 && octet1 <= 191)
                return "B";
            else if (octet1 >= 192 && octet1 <= 223)
                return "C";
            else if (octet1 >= 224 && octet1 <= 239)
                return "D";
            else if (octet1 >= 240 && octet1 <= 255)
                return "E";
            else
                return "Invalide";
        }

        private string CalculNetworkAddresse(int ip1, int ip2, int ip3, int ip4, int mask1, int mask2, int mask3, int mask4)
        {
            int net1 = ip1 & mask1;
            int net2 = ip2 & mask2;
            int net3 = ip3 & mask3;
            int net4 = ip4 & mask4;

            return $"{net1}.{net2}.{net3}.{net4}";
        }
        private string CalculBroadcastAddresse(int ip1, int ip2, int ip3, int ip4, int mask1, int mask2, int mask3, int mask4)
        {
            int broadcast1 = ip1 | ~mask1 & 0xFF;
            int broadcast2 = ip2 | ~mask2 & 0xFF;
            int broadcast3 = ip3 | ~mask3 & 0xFF;
            int broadcast4 = ip4 | ~mask4 & 0xFF;

            return $"{broadcast1}.{broadcast2}.{broadcast3}.{broadcast4}";
        }
        private string[] Calcul_FL_IP(string networkAddress, string broadcastAddress)
        {
            string[] networkParts = networkAddress.Split('.');
            string[] broadcastParts = broadcastAddress.Split('.');

            int firstIP1 = int.Parse(networkParts[0]);
            int firstIP2 = int.Parse(networkParts[1]);
            int firstIP3 = int.Parse(networkParts[2]);
            int firstIP4 = int.Parse(networkParts[3]) + 1;

            int lastIP1 = int.Parse(broadcastParts[0]);
            int lastIP2 = int.Parse(broadcastParts[1]);
            int lastIP3 = int.Parse(broadcastParts[2]);
            int lastIP4 = int.Parse(broadcastParts[3]) - 1;

            string firstIP = $"{firstIP1}.{firstIP2}.{firstIP3}.{firstIP4}";
            string lastIP = $"{lastIP1}.{lastIP2}.{lastIP3}.{lastIP4}";

            return new string[] { firstIP, lastIP };
        }
        private int CalculTotalIP(int mask1, int mask2, int mask3, int mask4)
        {
            int cidr = MaskToCIDR(mask1, mask2, mask3, mask4);
            return (int)Math.Pow(2, 32 - cidr);
        }
        private void btnNotice_Click(object sender, EventArgs e)
        {
            FormNotice formNotice = new FormNotice();
            formNotice.Show();
        }
    }
}
