namespace Shool2
{
     class Work
     {
         public string workName;
         public string studentid;
         public string predmetid;
         public string link;
         public float rating;
         public int znamka;

        
         public Work(string workName, string studentid, string predmetid)
         {
             this.workName = workName;
             this.studentid = studentid;
             this.predmetid = predmetid;

         }

         public string WorkName
         {
             get => workName;
             set => workName = value;
         }

         public string Studentid => studentid;

         public string Predmetid => predmetid;

         public string Link
         {
             get => link;
             set => link = value;
         }

         public float Rating
         {
             get => rating;
             set => rating = value;
         }

         public int Znamka
         {
             get => znamka;
             set => znamka = value;
         }
         
     }
}