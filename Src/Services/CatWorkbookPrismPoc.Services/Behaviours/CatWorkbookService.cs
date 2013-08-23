using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CatWorkbookPrismPoc.Services.Contracts.Faults;
using CatWorkbookPrismPoc.Services.Helpers;
using DataModel = CatWorkbookPrismPoc.Entities.Models;
using CatWorkbookPrismPoc.Services.Contracts;
using DataContract = CatWorkbookPrismPoc.Services.Contracts.Data;

namespace CatWorkbookPrismPoc.Services.Behaviours
{
    public class CatWorkbookService : ICatWorkbookService
    {

        #region Properties
        /// <summary>
        /// Returns the name of the service.
        /// </summary>
        public string ServiceName
        {
            get
            {
                return this.GetType().Name;
            }
            
        }

        #endregion

        #region Constructors

        public CatWorkbookService()
        {
            CatWorkbookService.ConfigureAutoMapper();
        }

        #endregion

        #region AutoMapper Configuration

        private static void ConfigureAutoMapper()
        {
            // AutoMapper configuration between Data Model and Data Contract
            Mapper.CreateMap<DataModel.Program, DataContract.Program>();

            // AutoMapper configuration between Data Contract and Data Model
            Mapper.CreateMap<DataContract.Program, DataModel.Program>();
        }

        #endregion

        /// <summary>
        /// Gets Program by ID
        /// </summary>
        /// <param name="programId"></param>
        /// <returns></returns>
        public DataContract.Program GetProgramById(int programId)
        {
            try
            {
                using (var context = new DataModel.UWWorkbookContext())
                {
                    var program = context.Programs.Where(p => p.ProgramID == programId).FirstOrDefault();

                    if (program == null)
                    {
                        throw new FaultException<ServiceException>(
                            ExceptionManager.HandleException(string.Format("Program ID {0} was not found.", programId)));
                    }

                    DataContract.Program dcProgram = Mapper.Map<DataContract.Program>(program);
                    return dcProgram;
                }
            }
            catch (Exception ex)
            {
                
                throw new FaultException<ServiceException>(ExceptionManager.HandleException(ex));
            }
        }
    }
}
