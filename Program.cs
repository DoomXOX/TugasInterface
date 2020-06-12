using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Akhir
{

    public interface Acara
    {
        string Nama { get; }
        string Duration { get; }
        string Date { get; }
        void StartEvent();
    }


    public class JalanSehat : Acara
    {
        public string Nama { get { return "Jalan Sehat"; } }
        public string Duration { get { return "1 Hari"; } }
        public string Date { get { return "25 April 2020"; } }
        public void StartEvent()
        {
            Console.WriteLine("Memulai acara " + Nama + " pada " + Date + " dengan estimasi waktu " + Duration);
        }
    }


    
    class Program
    {
        static void Main(string[] args)
        {
            Acara JalanSehatObj = new JalanSehat();
            JalanSehatObj.StartEvent();
        }
    }
}
