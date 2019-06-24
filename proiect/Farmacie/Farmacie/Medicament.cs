using System;
using System.Collections;
using System.IO;



namespace Farmacie
{
    internal class Medicament
    {
        const string strFile = "baza_de_date.txt";
        StreamReader sr = null;
        StreamWriter sw = null;

        internal Medicament()
        {
        }

        public string citire_bdd()
        {
            sr = new StreamReader(strFile);

            string tempStr = string.Empty;
            ArrayList arr = new ArrayList();

          
            while (sr.Peek() >= 0)
            {
                tempStr = sr.ReadLine();
                arr.Add(tempStr);
            }
            sr.Close();

            int nr_elem =  arr.Count;
            int[] nr_crt = new int[nr_elem];
            string[] nume = new string[nr_elem];
            int[] nr_nuc = new int[nr_elem];
            float[] pret = new float[nr_elem];
            string alllines = string.Empty;
            arr[0] = arr[0].ToString().Replace(" ", "     ");
            Console.WriteLine(arr[0].ToString());
            for (int i = 1; i < nr_elem; i++)
            {
                tempStr = arr[i].ToString();

               
                nr_crt[i] = int.Parse(tempStr.Substring(0, tempStr.IndexOf(' ')));
                tempStr = tempStr.Remove(0, tempStr.IndexOf(' ') + 1);

                nume[i] = tempStr.Substring(0, tempStr.IndexOf(' '));
                tempStr = tempStr.Remove(0, tempStr.IndexOf(' ') + 1);

                nr_nuc[i] = int.Parse(tempStr.Substring(0, tempStr.IndexOf(' ')));
                tempStr = tempStr.Remove(0, tempStr.IndexOf(' ') + 1);

                pret[i] = float.Parse(tempStr);
                alllines += String.Format("{0, -5} {1, -15} {2, -10} {3, -10}\n", nr_crt[i], nume[i], nr_nuc[i], pret[i]);
                if (nume[i].Length > 7)
                {    
                    Console.WriteLine(String.Format($"{nr_crt[i]}\t{nume[i]}\t{nr_nuc[i]}\t{pret[i]}"));
                }
                else
                {
                    Console.WriteLine(String.Format($"{nr_crt[i]}\t{nume[i]}\t\t{nr_nuc[i]}\t{pret[i]}"));
                }
            }
            alllines = arr[0] + "\n" + alllines;
            return alllines;
        }


        public void scrie_bdd()
        {
            int nr_crt = 0;
            string nume = string.Empty;
            int nr_nuc = 0;
            float pret = 0.0f;
            string optiune = string.Empty;

            string tempStr = string.Empty;
            int oldNr_crt = 0;
            sr = new StreamReader(strFile);
            tempStr = sr.ReadLine();
            while (sr.Peek() >= 0)
            {
                tempStr = sr.ReadLine();

                oldNr_crt = int.Parse(tempStr.Substring(0, tempStr.IndexOf(' ')));
                if (oldNr_crt >= nr_crt)
                    nr_crt = oldNr_crt + 1;
            }
            sr.Close();

            do
            {
                Console.WriteLine("Introdu numele medicamentului: ");
                nume = Console.ReadLine();

                Console.WriteLine($"Este {nume} corect? (D - da): ");
                optiune = Console.ReadLine();
                if (optiune == "d" || optiune == "D")
                    break;
                else
                    Console.WriteLine("Reintroduceti numele...");

            } while (true);


            do
            {
                Console.WriteLine("Introdu numaru de bucati: ");
            }
            while (!int.TryParse(Console.ReadLine(), out nr_nuc));
            do
            {
                Console.WriteLine("Introdu pretul per bucata: ");
            }
            while (!float.TryParse(Console.ReadLine(), out pret));


            Console.WriteLine("Doriti sa continuati cu adaugarea? (D - da): ");
            optiune = Console.ReadLine();
            if (optiune != "d" && optiune != "D")
            {
                Console.WriteLine("Se inchide actiunea");
                return;
            }

            sw = new StreamWriter(strFile, true);
            sw.WriteLine($"{nr_crt} {nume} {nr_nuc} {Convert.ToInt32(pret)}");
            Console.WriteLine("Scrierea in baza de date a fost efectuata cu succes");

            sw.Close();

        }
        public void editeaza_bdd()
        {
            string optiune = string.Empty;
            string entity = string.Empty;
            string temp = string.Empty;
            int nr_crt = 0;
            string nume = string.Empty;
            int nr_nuc = 0;
            float pret = 0.0f;
            bool wasFound = false;
            do
            {
                Console.WriteLine("Introdu numele medicamentului: ");
                nume = Console.ReadLine();

                Console.WriteLine($"Este {nume} corect? (D - da): ");
                optiune = Console.ReadLine();
                if (optiune == "d" || optiune == "D")
                    break;
                else
                    Console.WriteLine("Reintroduceti numele...");

            } while (true);

            
            sr = new StreamReader(strFile);
            sw = new StreamWriter("temp.txt");
            sw.WriteLine(sr.ReadLine()); 
            while (sr.Peek() >= 0)
            {
                entity = sr.ReadLine();
              
                nr_crt = int.Parse(entity.Substring(0, entity.IndexOf(' ')));
                temp = entity.Remove(0, entity.IndexOf(' ') + 1);
                temp = temp.Substring(0, temp.IndexOf(' '));
                if (temp == nume)
                {
                    wasFound = true;
                    Console.WriteLine($"Instanta veche <{entity}>");
                    do
                    {
                        Console.WriteLine("Introdu numele nou al medicamentului: ");
                        nume = Console.ReadLine();

                        Console.WriteLine($"Este {nume} corect? (D - da): ");
                        optiune = Console.ReadLine();
                        if (optiune == "d" || optiune == "D")
                            break;
                        else
                            Console.WriteLine("Reintroduceti numele...");

                    } while (true);


                    do
                    {
                        Console.WriteLine("Introdu numaru de bucati: ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out nr_nuc));
                    do
                    {
                        Console.WriteLine("Introdu pretul per bucata: ");
                    }
                    while (!float.TryParse(Console.ReadLine(), out pret));

                 
                    Console.WriteLine("Doriti sa continuati cu editarea? (D - da): ");
                    optiune = Console.ReadLine();
                    if (optiune != "d" && optiune != "D")
                    {
                        sw.Close();
                        Console.WriteLine("Se inchide actiunea");
                        return;
                    }
                       
                    sw.WriteLine($"{nr_crt} {nume} {nr_nuc} {Convert.ToInt32(pret)}");

                }
                else
                {
                    sw.WriteLine(entity);
                }
                
               
                   
            }
            sr.Close();
            sw.Close();
            File.Delete(strFile);
            File.Move("temp.txt", strFile); 
            if(!wasFound)
                Console.WriteLine("Entitatea nu a fost gasita");
        }

        public void cauta_bbd()
        {
            sr = new StreamReader(strFile);
         
            string entity = string.Empty;
            string nume =  string.Empty;
            string temp =  string.Empty;
            string optiune = string.Empty;

            do
            {
                Console.WriteLine("Introdu numele medicamentului: ");
                nume = Console.ReadLine();

                Console.WriteLine($"Este {nume} corect? (D - da): ");
                optiune = Console.ReadLine();
                if (optiune == "d" || optiune == "D")
                    break;
                else
                    Console.WriteLine("Reintroduceti numele...");

            } while (true);

            entity = sr.ReadLine();
            while (sr.Peek() >= 0)
            {
                entity = sr.ReadLine();
              
                temp = entity.Remove(0, entity.IndexOf(' ') + 1);
                temp = temp.Substring(0, temp.IndexOf(' '));
                if (temp == nume)
                {
                    sr.Close();
                    Console.WriteLine("Medicamentul exista");
                    return;
                }           
            }
            sr.Close();
            Console.WriteLine("Medicamentul nu a fost gasit");
        }
       


        public void sterge_bdd()
        {
            string nume =  string.Empty;
            string optiune = string.Empty;
            do
            {
                Console.WriteLine("Introdu numele medicamentului: ");
                nume = Console.ReadLine();

                Console.WriteLine($"Este {nume} corect? (D - da): ");
                optiune = Console.ReadLine();
                if (optiune == "d" || optiune == "D")
                    break;
                else
                    Console.WriteLine("Reintroduceti numele...");
            } while (true);

            Console.WriteLine("Doriti sa continuati cu stergerea? (D - da): ");
            optiune = Console.ReadLine();
            if (optiune != "d" && optiune != "D")
            {
                Console.WriteLine("Se inchide actiunea");
                return;
            }

            string entity;
            string temp;
            sr = new StreamReader(strFile);
            sw = new StreamWriter("temp.txt");
            sw.WriteLine(sr.ReadLine());

            while (sr.Peek() >= 0)
            {
                entity = sr.ReadLine();
                
                temp = entity.Remove(0, entity.IndexOf(' ') + 1);
                temp = temp.Substring(0, temp.IndexOf(' '));
                if (temp != nume)
                    sw.WriteLine(entity);
                
            }
            sr.Close();
            sw.Close();
            File.Delete(strFile);
            File.Move("temp.txt", strFile);
            Console.WriteLine("Entitate stearsa");
        }
    }

}