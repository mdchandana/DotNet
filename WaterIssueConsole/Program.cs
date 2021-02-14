using System;

namespace WaterIssueConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //========== Q = 5.3785 * (H - 0.385)^1.34 

            //===  Q = 5.3785 * (0.600-0.385) ^ 1.34;
            //var result = 5.3785 * (0.215);
            //var result2 = result*1.34;
            //var res=Math.Pow(0.215, 1.34);
            //var cubMeter = res * 5.3785;
            //var acft = cubMeter * 0.0008;
            /////     time duration




            //-------reading the height
            //double guageHeight = 0.600;
            double guageHeight = 0;
            Console.Write("Enter Gauge Height in Meters :");
            guageHeight = double.Parse(Console.ReadLine());


            ////Main cannel worked----------------------
            ////double guageHeight = 0.600;
            //var issueResult1 = guageHeight - 0.385;     
            //var powerResult= Math.Pow(issueResult1, 1.34);
            //var resultCumecs = powerResult * 5.3785;

            //Console.WriteLine($"Lb cannel Water issue for given height for 1 second :{Math.Round(resultCumecs,3)}");
            ////var resultAcft = resultCumecs * 0.0008;
            ////Console.WriteLine($"Lb cannel Water issue Result in ACFT for 1 second :{Math.Round(resultAcft,3)})");
            ////------------------------------------------





            ////Tack 02 D4----------------------
            //double H = guageHeight;
            //var track2D4Result1 = H * 0.1405-(0.00009);
            //var powerH= Math.Pow(H, 2);
            //var track2D4Result2 = 0.963 * powerH;
            //var resultCumecs = track2D4Result1 + track2D4Result2;
            //Console.WriteLine($"Tack 02 D4 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            ////------------------------------------------



            ////Tack 02 D6----------------------
            //double H = guageHeight;
            //var track2D6Result1 = H - 0.04;
            //var powerH_track2D6Result1 = Math.Pow(track2D6Result1, 1.0506);
            //var resultCumecs = 0.8298 * powerH_track2D6Result1;
            //Console.WriteLine($"Tack 02 D6 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            ////------------------------------------------


            ////Tack 01 D2----------------------
            //double H = guageHeight;
            //var powerH = Math.Pow(H, 2);
            //var track1D2Result1 = 0.0548 * H + 0.0002;
            //var track1D2Result2 = 1.3095 * powerH;
            //var resultCumecs = track1D2Result1 + track1D2Result2;
            //Console.WriteLine($"Tack 02 D6 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            ////------------------------------------------



            ////Tack 02 D8----------------------
            //double H = guageHeight;
            //var powerH = Math.Pow(H, 2);
            //var track2D8Result1 = 1.3878 * powerH;
            //var resultCumecs = track2D8Result1 + (0.6583 * H) - 0.0019;
            //Console.WriteLine($"Tack 02 D6 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            ////------------------------------------------


            ////Tack 02 FC 01----------------------
            //double H = guageHeight;
            //var powerH = Math.Pow(H, 2);
            //var track2FC1Result1 = 5.4662 * powerH;
            //var resultCumecs = track2FC1Result1 + (0.6308 * H) - 0.0003;
            //Console.WriteLine($"Tack 02 D6 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            ////------------------------------------------


            ////Tack 02 D9----------------------
            //double H = guageHeight;
            //var powerH = Math.Pow(H, 2);
            //var track2D92Result1 = 1.6506 * powerH;
            //var resultCumecs = track2D92Result1 - (0.0948 * H) - 0.0026;
            //Console.WriteLine($"Tack 02 D6 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            ////------------------------------------------

            ////Tack 03 D2----------------------
            //double H = guageHeight;
            //var powerH = Math.Pow(H, 2);
            //var track3D2Result1 = 0.2756 * powerH;
            //var resultCumecs = track3D2Result1 + (0.4663 * H) + 0.0039;
            //Console.WriteLine($"Tack 02 D6 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            ////------------------------------------------


            ////Tack 03 D3----------------------
            //double H = guageHeight;
            //var track3D3Result1 = H - 0.025;
            //var powerH = Math.Pow(track3D3Result1, 2.6567);
            //var resultCumecs = 3.984 * powerH;

            //Console.WriteLine($"Tack 02 D6 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            ////------------------------------------------



            ////Tack 03 D5----------------------
            //double H = guageHeight;
            //var powerH = Math.Pow(H, 2);
            //var resultCumecs = (1.0216 * powerH) - (0.0023 * H) - 0.0001;

            //Console.WriteLine($"Tack 02 D6 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            ////------------------------------------------





            ////Tack 03 D6-----------------   ===============  Program Result not tally to given result by doc
            //double H = guageHeight;
            //var powerH = Math.Pow(H, 2);
            //var resultCumecs = (0.7649 * powerH) + (0.1106 * H) - 0.0041;

            //Console.WriteLine($"Tack 02 D6 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            ////------------------------------------------



            ////Tack 03 D9-----------------  
            //double H = guageHeight;
            //var powerH = Math.Pow(H, 2);
            //var resultCumecs = (4.039 * powerH) + (0.0152 * H) + 0.0014;

            //Console.WriteLine($"Tack 02 D6 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            ////------------------------------------------


            //Tack 03 D9-----------------  
            double H = guageHeight;
            var powerH = Math.Pow(H, 2);
            var resultCumecs = (4.039 * powerH) + (0.0152 * H) + 0.0014;

            Console.WriteLine($"Tack 02 D6 Water issue for given height for 1 second :{Math.Round(resultCumecs, 3)}");
            //------------------------------------------




            Console.ReadKey();
            
        }
    }
}
