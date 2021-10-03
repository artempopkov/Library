using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace БиблиотекаБГУИР
{
    class DataContext
    {
        static Library context = SceletonContext.Instance;
        public static IQueryable<TEntity> Select<TEntity>()
            where TEntity : class
        {
            return context.Set<TEntity>();
        }

        public static void Insert<TEntity>(TEntity entity)
            where TEntity : class
        {
            try
            {
                context.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));

                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
            catch(Exception)
            {
                MessageBox.Show("Попытка дублирования данных");
            }

        }

        public static void Inserts<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class
        {

            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.ValidateOnSaveEnabled = false;

            context.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));


            foreach (TEntity entity in entities)
                context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();

            context.Configuration.AutoDetectChangesEnabled = true;
            context.Configuration.ValidateOnSaveEnabled = true;

        }

        public static void Update<TEntity>(TEntity entity)
            where TEntity : class
        {

            context.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));

            context.Entry<TEntity>(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public static void Delete<TEntity>(TEntity entity)
            where TEntity : class
        {
            try
            { 
                context.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));

                context.Entry<TEntity>(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch(Exception)
            {
                MessageBox.Show("Удалите связь данных и попробуйте снова");
            }

        }
    }
}
