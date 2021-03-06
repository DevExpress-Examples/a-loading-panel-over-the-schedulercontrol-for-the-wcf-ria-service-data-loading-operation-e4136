﻿
namespace SchedulerCarsSQLServerSLT.Web {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // Implements application logic using the CarsXtraSchedulingEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class SchedulingDomainService : LinqToEntitiesDomainService<CarsXtraSchedulingEntities> {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'CarScheduling' query.
        public IQueryable<CarScheduling> GetCarScheduling() {
            return this.ObjectContext.CarScheduling;
        }

        public IQueryable<Cars> GetCars() {
            return this.ObjectContext.Cars;
        }

        public void InsertCarScheduling(CarScheduling carScheduling) {
            if ((carScheduling.EntityState != EntityState.Detached)) {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(carScheduling, EntityState.Added);
            }
            else {
                this.ObjectContext.CarScheduling.AddObject(carScheduling);
            }
        }

        public void UpdateCarScheduling(CarScheduling currentCarScheduling) {
            this.ObjectContext.CarScheduling.AttachAsModified(currentCarScheduling, this.ChangeSet.GetOriginal(currentCarScheduling));
        }

        public void DeleteCarScheduling(CarScheduling carScheduling) {
            if ((carScheduling.EntityState != EntityState.Detached)) {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(carScheduling, EntityState.Deleted);
            }
            else {
                this.ObjectContext.CarScheduling.Attach(carScheduling);
                this.ObjectContext.CarScheduling.DeleteObject(carScheduling);
            }
        }
    }
}


