using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace demo21jan21
{
    class Program
    {
        static void etalase(List<int> orders)
        {
            if (!orders.Any())
            {
                Console.Clear();
                Console.WriteLine("=============== MENU ===============");
                Console.WriteLine("1 . Minuman");
                Console.WriteLine("2 . Makanan");
                Console.WriteLine("0 . EXIT");
                Console.WriteLine("====================================");
                Console.Write("Pilih opsi : ");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("=============== MENU ===============");
                Console.WriteLine("1 . Minuman");
                Console.WriteLine("2 . Makanan");
                Console.WriteLine("3 . Lanjut Pembayaran");
                Console.WriteLine("====================================");
                Console.Write("Pilih opsi : ");
            }

        }
        static void subMenu(int opsi,List<int> orders, List<string> itemOrders, List<int> qtyOrders)
        {
            switch (opsi)
            {
                case 1:
                    menuMinuman(orders, itemOrders, qtyOrders);
                    break;
                case 2:
                    menuMakanan(orders, itemOrders, qtyOrders);
                    break;
                default:
                    if (!orders.Any())
                    {
                        Console.WriteLine("TERIMA KASIH!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("_____________Berikut pesanan anda______________");
                        break;
                    }

                    
                        
            }
        }
        static int TotalMenuMinuman(int opsi, int qty)
        {
            if (opsi == 1)
            {
                return 5000 * qty;
            }
            else if (opsi == 2)
            {
                return 8000 * qty;
            }
            else if (opsi == 3)
            {
                return 2000 * qty;
            }
            else
            {
                return 0;
            }
        }
        static void menuMinuman(List<int> orders, List<string> itemOrders, List<int> qtyOrders)
        {
            Console.Clear();
            Console.WriteLine("=========== MENU MINUMAN ===========");
            Console.WriteLine("1. ES SODA   - Rp.5000");
            Console.WriteLine("2. ES JERUK  - Rp.8000");
            Console.WriteLine("3. ES TEH    - Rp.2000");
            Console.WriteLine("====================================");
            Console.Write("Pilih opsi : ");
            int opsi = Convert.ToInt32(Console.ReadLine());
            if (opsi > 3)
            {
                Console.WriteLine("Barang Tidak ada");
            }
            else
            {
                Console.Write("Berapa Banyak : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                int harga = TotalMenuMinuman(opsi, qty);
                itemOrders.Add(findNamaMinuman(opsi));
                qtyOrders.Add(qty);
                orders.Add(harga);

            }


        }
        static int TotalMenuMakanan(int opsi, int qty)
        {
            if (opsi == 1)
            {
                return 10000 * qty;
            }
            else if (opsi == 2)
            {
                return 15000 * qty;
            }
            else if (opsi == 3)
            {
                return 12000 * qty;
            }
            else
            {
                return 0;
            }
        }
        static void menuMakanan(List<int> orders, List<string> itemOrders, List<int> qtyOrders)
        {
            Console.Clear();
            Console.WriteLine("=========== MENU MAKANAN ===========");
            Console.WriteLine("1. NASI GORENG  - Rp.10.000");
            Console.WriteLine("2. MIE AYAM     - Rp.15.000");
            Console.WriteLine("3. SOTO KUDUS   - Rp.12.000");
            Console.WriteLine("====================================");
            Console.Write("Pilih opsi : ");
            int opsi = Convert.ToInt32(Console.ReadLine());
            if (opsi > 3)
            {
                Console.WriteLine("Barang Tidak ada");
            }
            else
            {
                Console.Write("Berapa Banyak : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                int harga = TotalMenuMakanan(opsi, qty);
                itemOrders.Add(findNamaMakanan(opsi));
                qtyOrders.Add(qty);
                orders.Add(harga);

            }
        }
        
        static string findNamaMinuman(int opsi)
        {
            switch (opsi)
            {
                case 1:
                    return "Es Soda";
                case 2:
                    return "Es Jeruk";
                case 3:
                    return "Es Teh";
                default:
                    return "Tidak ditemukan";
            }
        }

        static string findNamaMakanan(int opsi)
        {
            switch (opsi)
            {
                case 1:
                    return "Nasi Goreng";
                case 2:
                    return "Mie Ayam";
                case 3:
                    return "Soto Kudus";
                default:
                    return "Tidak ditemukan";
            }
        }

        static void MenuAdmin()
        {
            Console.Clear();
            Console.WriteLine("=============== ADMIN ===============");
            Console.WriteLine("1 . Minuman");
            Console.WriteLine("2 . Makanan");
            Console.WriteLine("0 . EXIT");
            Console.WriteLine("====================================");
        }

        static void subMenuAdmin(int opsi, 
            List<string> itemMinuman, List<int> priceMinuman, List<int> qtyMinuman,
            List<string> itemMakanan, List<int> priceMakanan, List<int> qtyMakanan
            )
        {
            switch (opsi)
            {
                case 1:
                    SubMenuMinumanAdmin(itemMinuman, priceMinuman, qtyMinuman);
                    break;
                case 2:
                    SubMenuMakananAdmin(itemMakanan, priceMakanan, qtyMakanan);
                    break;
                default:
                    Console.WriteLine("TERIMA KASIH!");
                    break;



            }
        }

        /// MINUMAN
        static void SubMenuMinumanAdmin(List<string> itemMinuman, List<int> priceMinuman, List<int> qtyMinuman)
        {
            Console.Clear();
            Console.WriteLine("=============== ADMIN ===============");
            Console.WriteLine("1. Lihat Minuman");
            Console.WriteLine("2. Tambah Minuman");
            Console.WriteLine("3. Ubah Ketersediaan Minuman");
            Console.WriteLine("4. Hapus Minuman");
            Console.WriteLine("5. Kembali");
            Console.WriteLine("====================================");
            Console.Write("Pilih opsi : ");
            int opsi = Convert.ToInt32(Console.ReadLine());
            OpsiSubMenuAdminMinuman(opsi, itemMinuman, priceMinuman, qtyMinuman);
        }
        static void OpsiSubMenuAdminMinuman(int opsi,List<string> itemMinuman, List<int> priceMinuman, List<int> qtyMinuman)
        {
            switch (opsi)
            {
                case 0:
                    SubMenuMinumanAdmin(itemMinuman, priceMinuman, qtyMinuman);
                    break;
                case 1:
                    showMinuman(itemMinuman, priceMinuman, qtyMinuman);
                    break;
                case 2:
                    AddMinuman(itemMinuman, priceMinuman, qtyMinuman);
                    break;
                case 3:
                    EditQtyMinuman(itemMinuman, priceMinuman, qtyMinuman);
                    break;
                case 4:
                    deleteMinuman(itemMinuman, priceMinuman, qtyMinuman);
                    break;
                default:
                    break;
            }

        }
       

        static void showMinuman(List<string> itemMinuman, List<int> priceMinuman, List<int> qtyMinuman)
        {
            int num;
            string jawaban = "n";

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MINUMAN ============");
                for (int i = 0; i < itemMinuman.Count; i++)
                {
                    Console.WriteLine(num + ". " + itemMinuman[i] + ", Harga Rp." + priceMinuman[i] + ", Stok " + qtyMinuman[i]);
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();

                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMinuman(opsi, itemMinuman, priceMinuman, qtyMinuman);
                }
                else
                {
                    jawaban = "n";
                }
                
            }
            
        }
        static void AddMinuman(List<string> itemMinuman, List<int> priceMinuman, List<int> qtyMinuman)
        {
            string jawaban = "n";

            while (jawaban == "n")
            {
                Console.Clear();
                Console.WriteLine("========== TAMBAH MINUMAN ============");
                Console.Write("Nama Minuman        :"); string nama = Console.ReadLine();
                Console.Write("Harga Minuman       :"); int harga = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kuantitas Minuman   :"); int stok = Convert.ToInt32(Console.ReadLine());
                itemMinuman.Add(nama);
                priceMinuman.Add(harga);
                qtyMinuman.Add(stok);
                Console.WriteLine("======================================");

                Console.WriteLine("\n Item telah berhasil ditambah");
                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();

                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMinuman(opsi, itemMinuman, priceMinuman, qtyMinuman);
                }
                else
                {
                    jawaban = "n";
                }
            }
            

        }
        static void EditQtyMinuman(List<string> itemMinuman, List<int> priceMinuman, List<int> qtyMinuman)
        {
            string jawaban = "n";
            int num;

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MINUMAN ============");
                for (int i = 0; i < itemMinuman.Count; i++)
                {
                    Console.WriteLine(num + ". " + itemMinuman[i] + ", Harga Rp." + priceMinuman[i] + ", Stok " + qtyMinuman[i]);
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Nomor item yang ingin diubah? : ");
                int noItem = Convert.ToInt32(Console.ReadLine());
                if (noItem != 0)
                {
                    Console.Write("Jumlah Ketersidaan baru : ");
                    int newQtyMinuman = Convert.ToInt32(Console.ReadLine());
                    qtyMinuman[noItem - 1] = newQtyMinuman;
                    Console.WriteLine("Ketersidaan berhasil diubah");
                }
                else
                {
                    Console.WriteLine("Data tidak ditemukan");
                }

                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();
                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMinuman(opsi, itemMinuman, priceMinuman, qtyMinuman);
                }
                else
                {
                    jawaban = "n";
                }
            }
        }
        static void deleteMinuman(List<string> itemMinuman, List<int> priceMinuman, List<int> qtyMinuman)
        {
            string jawaban = "n";
            int num;

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MINUMAN ============");
                for (int i = 0; i < itemMinuman.Count; i++)
                {
                    Console.WriteLine(num + ". " + itemMinuman[i] + ", Harga Rp." + priceMinuman[i] + ", Stok " + qtyMinuman[i]);
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Nomor item yang ingin dihapus? : ");
                int noItem = Convert.ToInt32(Console.ReadLine());
                if (noItem != 0)
                {
                    itemMinuman.RemoveAt(noItem - 1);
                    priceMinuman.RemoveAt(noItem - 1);
                    qtyMinuman.RemoveAt(noItem - 1);
                    Console.WriteLine("Item berhasil dihapus");
                }
                else
                {
                    Console.WriteLine("Data tidak ditemukan");
                }

                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();
                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMinuman(opsi, itemMinuman, priceMinuman, qtyMinuman);
                }
                else
                {
                    jawaban = "n";
                }
            }

        }


        ///MAKANAN//

        static void SubMenuMakananAdmin(List<string> itemMakanan, List<int> priceMakanan, List<int> qtyMakanan)
        {
            Console.Clear();
            Console.WriteLine("=============== ADMIN ===============");
            Console.WriteLine("1. Lihat Makanan");
            Console.WriteLine("2. Tambah Makanan");
            Console.WriteLine("3. Ubah Ketersediaan Makanan");
            Console.WriteLine("4. Hapus Makanan");
            Console.WriteLine("5. Kembali");
            Console.WriteLine("====================================");
            Console.Write("Pilih opsi : ");
            int opsi = Convert.ToInt32(Console.ReadLine());
            OpsiSubMenuAdminMakanan(opsi, itemMakanan, priceMakanan, qtyMakanan);
        }
        static void OpsiSubMenuAdminMakanan(int opsi, List<string> itemMakanan, List<int> priceMakanan, List<int> qtyMakanan)
        {
            switch (opsi)
            {
                case 0:
                    SubMenuMakananAdmin(itemMakanan, priceMakanan, qtyMakanan);
                    break;
                case 1:
                    showMakanan(itemMakanan, priceMakanan, qtyMakanan);
                    break;
                case 2:
                    AddMakanan(itemMakanan, priceMakanan, qtyMakanan);
                    break;
                case 3:
                    EditQtyMakanan(itemMakanan, priceMakanan, qtyMakanan);
                    break;
                case 4:
                    deleteMakanan(itemMakanan, priceMakanan, qtyMakanan);
                    break;
                default:
                    break;
            }

        }

        static void showMakanan(List<string> itemMakanan, List<int> priceMakanan, List<int> qtyMakanan)
        {
            int num;
            string jawaban = "n";

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MAKANAN ============");
                for (int i = 0; i < itemMakanan.Count; i++)
                {
                    Console.WriteLine(num + ". " + itemMakanan[i] + ", Harga Rp." + priceMakanan[i] + ", Stok " + qtyMakanan[i]);
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();

                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMakanan(opsi, itemMakanan, priceMakanan, qtyMakanan);
                }
                else
                {
                    jawaban = "n";
                }

            }

        }
        static void AddMakanan(List<string> itemMakanan, List<int> priceMakanan, List<int> qtyMakanan)
        {
            string jawaban = "n";

            while (jawaban == "n")
            {
                Console.Clear();
                Console.WriteLine("========== TAMBAH MAKANAN ============");
                Console.Write("Nama Makanan        :"); string nama = Console.ReadLine();
                Console.Write("Harga Makanan       :"); int harga = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kuantitas Makanan   :"); int stok = Convert.ToInt32(Console.ReadLine());
                itemMakanan.Add(nama);
                priceMakanan.Add(harga);
                qtyMakanan.Add(stok);
                Console.WriteLine("======================================");

                Console.WriteLine("\n Item telah berhasil ditambah");
                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();

                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMakanan(opsi, itemMakanan, priceMakanan, qtyMakanan);
                }
                else
                {
                    jawaban = "n";
                }
            }


        }
        static void EditQtyMakanan(List<string> itemMakanan, List<int> priceMakanan, List<int> qtyMakanan)
        {
            string jawaban = "n";
            int num;

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MAKANAN ============");
                for (int i = 0; i < itemMakanan.Count; i++)
                {
                    Console.WriteLine(num + ". " + itemMakanan[i] + ", Harga Rp." + priceMakanan[i] + ", Stok " + qtyMakanan[i]);
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Nomor item yang ingin diubah? : ");
                int noItem = Convert.ToInt32(Console.ReadLine());
                if (noItem != 0)
                {
                    Console.Write("Jumlah Ketersidaan baru : ");
                    int newQtyMinuman = Convert.ToInt32(Console.ReadLine());
                    qtyMakanan[noItem - 1] = newQtyMinuman;
                    Console.WriteLine("Ketersidaan berhasil diubah");
                }
                else
                {
                    Console.WriteLine("Data tidak ditemukan");
                }

                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();
                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMakanan(opsi, itemMakanan, priceMakanan, qtyMakanan);
                }
                else
                {
                    jawaban = "n";
                }
            }
        }
        static void deleteMakanan(List<string> itemMakanan, List<int> priceMakanan, List<int> qtyMakanan)
        {
            string jawaban = "n";
            int num;

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MAKANAN ============");
                for (int i = 0; i < itemMakanan.Count; i++)
                {
                    Console.WriteLine(num + ". " + itemMakanan[i] + ", Harga Rp." + priceMakanan[i] + ", Stok " + qtyMakanan[i]);
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Nomor item yang ingin dihapus? : ");
                int noItem = Convert.ToInt32(Console.ReadLine());
                if (noItem != 0)
                {
                    itemMakanan.RemoveAt(noItem - 1);
                    priceMakanan.RemoveAt(noItem - 1);
                    qtyMakanan.RemoveAt(noItem - 1);
                    Console.WriteLine("Item berhasil dihapus");
                }
                else
                {
                    Console.WriteLine("Data tidak ditemukan");
                }

                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();
                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMakanan(opsi, itemMakanan, priceMakanan, qtyMakanan);
                }
                else
                {
                    jawaban = "n";
                }
            }

        }

        static void Main(string[] args)
        {
            

            string userAdmin = "admin";
            string passAdmin = "123";

            List<string> itemMinuman = new List<string>();
            itemMinuman.Add("Es Soda");
            itemMinuman.Add("Es Teh");
            itemMinuman.Add("Es Jeruk");
            List<int> priceMinuman = new List<int>();
            priceMinuman.Add(5000);
            priceMinuman.Add(2000);
            priceMinuman.Add(8000);
            List<int> qtyMinuman = new List<int>();
            qtyMinuman.Add(5);
            qtyMinuman.Add(5);
            qtyMinuman.Add(5);

            List<string> itemMakanan = new List<string>();
            itemMakanan.Add("Nasi Goreng");
            itemMakanan.Add("Mie Ayam");
            itemMakanan.Add("Soto Kudus");
            List<int> priceMakanan = new List<int>();
            priceMakanan.Add(10000);
            priceMakanan.Add(15000);
            priceMakanan.Add(12000);
            List<int> qtyMakanan = new List<int>();
            qtyMakanan.Add(5);
            qtyMakanan.Add(5);
            qtyMakanan.Add(5);

           


            ////////////////////////////////////////////////////////////////////////////////////////
          
            List<int> orders = new List<int>();
            List<string> itemOrders = new List<string>();
            List<int> qtyOrders = new List<int>();

            

            Console.Write("Masukan Username: ");string username = Console.ReadLine();
            Console.Write("Masukan Password: ");string passwword = Console.ReadLine();

            if (username == userAdmin && passwword == passAdmin)
            {
                int opsi = 1;
                while (opsi >= 1 && opsi <= 2)
                {
                    MenuAdmin();
                    opsi = Convert.ToInt32(Console.ReadLine());
                    subMenuAdmin(opsi, 
                        itemMinuman, priceMinuman, qtyMinuman,
                        itemMakanan,priceMakanan,qtyMakanan
                        );
                }
            }
            else
            {
                int opsi = 1;
                while (opsi >= 1 && opsi <= 2)
                {
                    etalase(orders);

                    opsi = Convert.ToInt32(Console.ReadLine());

                    subMenu(opsi, orders, itemOrders, qtyOrders);

                    if (!orders.Any())
                    {

                        Console.WriteLine("");

                    }
                    else
                    {
                        Console.WriteLine("================= INVOICE =====================");
                        int j = 1;
                        int total = 0;

                        for (int i = 0; i < itemOrders.Count; i++)
                        {
                            Console.WriteLine(j + ". " + itemOrders[i] + " = Rp." + orders[i] / qtyOrders[i] + " x " + qtyOrders[i] + " = Rp." + orders[i]);
                            total = total + orders[i];
                            j += 1;
                        }
                        Console.WriteLine("===============================================");
                        Console.WriteLine("Jumlah yang harus dibayar adalah Rp." + total);
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                    }


                }
            }

            
            


            
        }
    }
}
