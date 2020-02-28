using System.Collections.Generic;

namespace Seek.Data
{
    public class Jobs
    {
        public string Name { get; set; }
        public string Uri { get; set; }

        public static List<Jobs> CreateList()
        {
            return new List<Jobs>
            {
                new Jobs{ Name = "Accounting", Uri="/?classification=1200" },
                new Jobs{ Name = "Administration, Office Support", Uri="/?classification=6251" },
                new Jobs{ Name = "Advertising, Arts, Media", Uri="/?classification=6304" },
                new Jobs{ Name = "Banking, Financial Services", Uri="/?classification=1203" },
                new Jobs{ Name = "Call Centre, Customer Service", Uri="/?classification=1204" },
                new Jobs{ Name = "CEO, General Management", Uri="/?classification=7019" },
                new Jobs{ Name = "Community Services, Development", Uri="/?classification=6163" },
                new Jobs{ Name = "Construction", Uri="/?classification=1206" },
                new Jobs{ Name = "Consulting, Strategy", Uri="/?classification=6076" },
                new Jobs{ Name = "Design, Architecture", Uri="/?classification=6263" },
                new Jobs{ Name = "Education, Training", Uri="/?classification=6123" },
                new Jobs{ Name = "Engineering", Uri="/?classification=1209" },
                new Jobs{ Name = "Farming, Animals, Conservation", Uri="/?classification=6205" },
                new Jobs{ Name = "Government, Defence", Uri="/?classification=1210" },
                new Jobs{ Name = "Healthcare, Medical", Uri="/?classification=1211" },
                new Jobs{ Name = "Hospitality, Tourism", Uri="/?classification=1212" },
                new Jobs{ Name = "Information, Communication Technology", Uri="/?classification=6281" },
                new Jobs{ Name = "Insurance, Superannuation", Uri="/?classification=1214" },
                new Jobs{ Name = "Legal", Uri="/?classification=1216" },
                new Jobs{ Name = "Manufacturing, Transport, Logistics", Uri="/?classification=6092" },
                new Jobs{ Name = "Marketing, Communications", Uri="/?classification=6008" },
                new Jobs{ Name = "Mining, Resources, Energy", Uri="/?classification=6058" },
                new Jobs{ Name = "Real Estate, Property", Uri="/?classification=1220" },
                new Jobs{ Name = "Retail, Consumer Products", Uri="/?classification=6043" },
                new Jobs{ Name = "Sales", Uri="/?classification=6362" },
                new Jobs{ Name = "Science, Technology", Uri="/?classification=1223" },
                new Jobs{ Name = "Self Employment", Uri="/?classification=6261" },
                new Jobs{ Name = "Sport, Recreation", Uri="/?classification=6246" },
                new Jobs{ Name = "Trades, Services", Uri="/?classification=1225" }
            };
        }
    }
}
