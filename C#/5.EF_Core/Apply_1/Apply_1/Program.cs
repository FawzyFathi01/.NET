namespace Apply_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wallets wallet = new Wallets()
            {
                Balance = 8500m,
                Holder = "Eman"
            };

            //1-InsertItem(wallet);
            //2-UpdateItem(2);
            //3-DeleteItem(6);
            //4-RetriveItem();
            //5-Query_Data();
            //6-Transaction(7,2,1000m);
     
        }

        static void RetriveItem ()
        {
            //int idRetrive = 2;
            using (var context = new AppDpContext())
            {
                foreach (var wallet in context.Wallets)
                    Console.WriteLine(wallet);
                //var res = context.Wallets.FirstOrDefault(w => w.Id == idRetrive);
                //Console.WriteLine(res);
            }
        }

        static void InsertItem (Wallets wallets)
        {
            if (wallets == null) {
                Console.WriteLine("No Item");
                return; 
            }

            using (var context = new AppDpContext())
            {
                context.Wallets.Add(wallets);
                context.SaveChanges();  
            }

        }

        static void UpdateItem(int id)
        {
            using (var context = new AppDpContext())
            {
                var wallet = context.Wallets.Single(w => w.Id == id);
                wallet.Balance += 1000;
                context.SaveChanges();
            }
        }

        static void DeleteItem(int id)
        {
            using (var context = new AppDpContext())
            {
                var wallet = context.Wallets.Single(w => w.Id == id);
                context.Wallets.Remove(wallet);               
                context.SaveChanges();
            }
        }


        static void Query_Data()
        {
            using (var context = new AppDpContext())
            {
                var res = context.Wallets.Where(w => w.Balance > 6000);
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void Transaction(int from,int to, decimal amountTransfare)
        {
            using (var context = new AppDpContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {

                    var fromWallet = context.Wallets.Single(w => w.Id == from);
                    var toWallet = context.Wallets.Single(w => w.Id == to);

                    fromWallet.Balance -= amountTransfare;
                    context.SaveChanges();

                    toWallet.Balance += amountTransfare;
                    context.SaveChanges();

                    transaction.Commit();
                }
            }
        }





    }
}
