using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<String> person = new ObservableCollection<String>()
            {
                "Denieall",
                "Joenethen",
                "DJ",
            };


            person.CollectionChanged += Person_CollectionChanged;

            person.RemoveAt(2);
            person.Add("Joe");
        }

        private static void Person_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Type of change: " + e.Action);
            

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("New item is: " + e.NewItems[0]);
                
            }

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Old item is: " + e.OldItems[0]);
            }

            Console.WriteLine("\n");

        }
    }
}
