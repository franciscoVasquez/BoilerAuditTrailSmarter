using System.Data.Common;
using Abp.Zero.EntityFramework;
using ProyetoSmarterAudit.Authorization.Roles;
using ProyetoSmarterAudit.MultiTenancy;
using ProyetoSmarterAudit.Users;
using ProyetoSmarterAudit.Auditoria;
using TaskSystem.Entities;
using System.Reflection;
using System.Data.Entity;

namespace ProyetoSmarterAudit.EntityFramework
{
    public class ProyetoSmarterAuditDbContext : AbpZeroDbContext<Tenant, Role, User> 
    {
        //TODO: Define an IDbSet for your Entities...

        public virtual IDbSet<cCuentaBancaria> Cuenta { get; set; }
        public virtual IDbSet<cAuditoria> Auditoria { get; set; }


        //public override int SaveChanges()
        //{
        //    throw new InvalidOperationException("Debe ser proporcionado el usuario que hace el cambio, para efectos de auditoría.");
        //}

        //public int SaveChanges(string userId)
        //{
        //    // Obtiene todos los cambios que se hicieron es un contexto
        //    foreach (var ent in this.ChangeTracker.Entries().Where(p => p.State == System.Data.Entity.EntityState.Added || p.State == System.Data.Entity.EntityState.Deleted || p.State == System.Data.Entity.EntityState.Modified))
        //    {
        //        // Por cada cambio de un registro, obtiene los valores para insertar en Auditoría. 
        //        AuditTrailModel.Auditoria x = new AuditTrailModel.Auditoria();
        //        x = RegistrosAuditoria(ent, userId);
        //        this.Auditoria.Add(x);
        //    }

        //    // Devuelve el método SaveChange() original de EF, que guardará los cambios principales con la auditoria
        //    return base.SaveChanges();
        //}


        //private Auditoria RegistrosAuditoria(DbEntityEntry entry, string UserName)
        //{
        //    Auditoria audit = new Auditoria();
        //    //audit.ID_AUDIT = Guid.NewGuid().ToString();
        //    audit.FechaCambio = DateTime.Now;
        //    // Obtiene el atributo Table() si existe
        //    TableAttribute tableAttr = entry.Entity.GetType().GetCustomAttributes(typeof(TableAttribute), false).SingleOrDefault() as TableAttribute;

        //    // Obtiene el nombre de la table en el contexto (Si tiene un nombre en el atributo tabla, lo usa, sino toma el nombre de la clase)
        //    audit.NombreTabla = tableAttr != null ? tableAttr.Name : entry.Entity.GetType().Name;
        //    audit.UserID = UserName;

        //    if (entry.State == EntityState.Added)
        //    {//entrada es un nuevo registro
        //        audit.ValorActual = GetValueToXml(entry, false);
        //        audit.ValorAnterior = null;
        //        audit.TipoEvento = Accion.Evento.Agregar.ToString();
        //        audit.NombreColumnas = "TODAS";
        //    }
        //    else if (entry.State == EntityState.Deleted)
        //    {//entrada fue eliminada
        //        audit.ValorAnterior = GetValueToXml(entry, true);
        //        audit.ValorActual = null;
        //        audit.TipoEvento = Accion.Evento.Eliminar.ToString();
        //        audit.NombreColumnas = "TODAS";
        //    }
        //    else
        //    {//entrada fue modificada
        //        audit.ValorAnterior = GetValueToXml(entry, true);
        //        audit.ValorActual = GetValueToXml(entry, false);
        //        audit.TipoEvento = Accion.Evento.Actualizar.ToString();

        //        foreach (string propertyName in entry.OriginalValues.PropertyNames)
        //        {
        //            // Para modificación, tomamos solo las columnas que han sido modificadas. 
        //            if (!object.Equals(entry.OriginalValues.GetValue<object>(propertyName), entry.CurrentValues.GetValue<object>(propertyName)))
        //            {
        //                audit.NombreColumnas = (audit.NombreColumnas == null) ? propertyName : audit.NombreColumnas + "," + propertyName;
        //            }
        //        }

        //    }

        //    return audit;
        //}

        //private string GetValueToXml(DbEntityEntry entry, bool ValorAnterior)
        //{
        //    object target = CloneEntity((Object)entry.Entity);
        //    var objectStateEntry = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager.GetObjectStateEntry(entry.Entity);
        //    var key = objectStateEntry.EntityKey;
        //    if (ValorAnterior)
        //    {
        //        foreach (string propName in entry.OriginalValues.PropertyNames)
        //        {
        //            object setterValue = null;
        //            //Se obtiene el valor Nuevo
        //            setterValue = entry.OriginalValues[propName];
        //            //Se busca las propiedades que se actualizaron 
        //            PropertyInfo propInfo = target.GetType().GetProperty(propName);
        //            //se inicializa la propiedad en caso que no tenga valores
        //            if (setterValue == DBNull.Value)
        //            {//
        //                setterValue = null;
        //            }
        //            propInfo.SetValue(target, setterValue, null);
        //        }//end foreach
        //    }
        //    else
        //    {
        //        foreach (string propName in entry.CurrentValues.PropertyNames)
        //        {
        //            object setterValue = null;
        //            //Se obtiene el valor Nuevo

        //            setterValue = entry.CurrentValues[propName];


        //            //Se busca las propiedades que se actualizaron 
        //            PropertyInfo propInfo = target.GetType().GetProperty(propName);
        //            //se inicializa la propiedad en caso que no tenga valores
        //            if (setterValue == DBNull.Value)
        //            {//
        //                setterValue = null;
        //            }
        //            propInfo.SetValue(target, setterValue, null);
        //        }//end foreach

        //    }

        //    JavaScriptSerializer serializer = new JavaScriptSerializer();
        //    var output = serializer.Serialize(target);

        //    // }
        //    return output;
        //}

        //public Object CloneEntity(Object obj)
        //{
        //    DataContractSerializer dcSer = new DataContractSerializer(obj.GetType());
        //    MemoryStream memoryStream = new MemoryStream();

        //    dcSer.WriteObject(memoryStream, obj);
        //    memoryStream.Position = 0;

        //    Object newObject = (Object)dcSer.ReadObject(memoryStream);
        //    return newObject;
        //}
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ProyetoSmarterAuditDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ProyetoSmarterAuditDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ProyetoSmarterAuditDbContext since ABP automatically handles it.
         */
        public ProyetoSmarterAuditDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ProyetoSmarterAuditDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ProyetoSmarterAuditDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
