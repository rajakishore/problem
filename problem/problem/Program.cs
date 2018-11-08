using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();

            RecipientJson r = new RecipientJson();
            var recipientList = r.GetJson();
            List<Recipient> recipients = recipientList.recipients.ToList();
            
            for (int i = 0; i < recipients.Count ; i++)
            {
                for (int j = i+1; j < recipients.Count; j++)
                {
                    var matches = recipients[i].tags.Intersect(recipients[j].tags).ToList();
                    if(matches.Count >= 2)
                    {
                      string matchFound = recipients[i].name + "," + recipients[j].name;
                        result.Add(matchFound);
                      Console.Write(matchFound + "|");
                    }
                }

            }
            Console.Read();

        }
    }
}
