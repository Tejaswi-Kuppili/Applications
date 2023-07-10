using AutoMapper;
using BusinessModels;
using DataModels;
using System.Reflection;

namespace DataLayer
{
    /// <summary>
    /// Storing user data and displaying all the usernames
    /// </summary>
    internal class DALAuthentication : IDALAuthentication
    {
        /// <summary>
        /// Add user details to the DataSource using the ConvertModel method
        /// </summary>
        /// <param name="user"></param>
        public void AddData(BusinessModels.User user)
        {
            DataSource.users.Add(ConvertModel<BusinessModels.User, DataModels.User>(user));
            //DataModels.User dataUser = ConvertBusinessModelToDataModel(user);
            //DataModels.User dataUser = ConvertBusinessModelToDataModel<BusinessModels.User, DataModels.User>(user);
        }

        public void GetObj()
        {
            for (int i = 0; i < DataSource.users.Count; i++)
            {
                Console.WriteLine(DataSource.users[i].UserName);
            }
        }
        /// <summary>
        /// Method to check the username is already existing in our database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsUserExist(BusinessModels.User user)
        {
            for (int i = 0; i < DataSource.users.Count; i++)
            {
                if (DataSource.users[i].UserName == user.UserName)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Method to check the username and password matches with the existing database details
        /// </summary>
        /// <param name="user"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsLoginExist(BusinessModels.User users, string Username, string password)
        {
            DataModels.User userExist = DataSource.users.Find(u => u.UserName == Username && u.Password == password);
            if (userExist != null)
            {
                return true;
            }
            return false;
        }












        /// <summary>
        /// Generic Method to convert Business Model to Data Model and vice-versa
        /// </summary>
        /// <typeparam name="TSourceModel"></typeparam>
        /// <typeparam name="TTargetModel"></typeparam>
        /// <param name="businessModel"></param>
        /// <returns></returns>
        public dynamic ConvertModel<TSourceModel, TTargetModel>(dynamic Model)
            where TSourceModel : new()
            where TTargetModel : new()
        {
            //Providing all the Mapping Configuration
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSourceModel, TTargetModel>();
                // .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username));
            });
            // Creating IMapper instance
            IMapper mapper = configuration.CreateMapper();
            TTargetModel targetModel = mapper.Map<TTargetModel>(Model);
            return targetModel;
        }

        /* TTargetModel targetModel = Activator.CreateInstance<TTargetModel>();
        TTargetModel targetModel = new TTargetModel();
        PropertyInfo[] sourceProperties = typeof(TSourceModel).GetProperties();
        PropertyInfo[] targetProperties = typeof(TTargetModel).GetProperties();
        foreach (var sourceProperty in sourceProperties)
        {
            foreach (var targetProperty in targetProperties)
            {
                if (sourceProperty.Name == targetProperty.Name && sourceProperty.PropertyType == targetProperty.PropertyType)
                {
                    targetProperty.SetValue(targetModel, sourceProperty.GetValue(model));
                    break;
                }
            }
        }
        return targetModel;*/




















        /// <summary>
        /// Non-Generic Method
        /// </summary>
        /// <param name="businessModel"></param>
        /// <returns></returns>
        /*public dynamic ConvertBusinessModelToDataModel(dynamic businessModel)
        {
            PropertyInfo[] properties = businessModel.GetType().GetProperties();

            // Iterate over the properties
            foreach (PropertyInfo property in properties)
            {
                // Get the value of the property
                object value = property.GetValue(businessModel);
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<BusinessModels.User, DataModels.User>()
                        .ForAllMembers(opts =>
                        {
                            opts.MapFrom((src, dest, srcMember, context) =>
                            {
                                var destinationMember = context.Mapper.ConfigurationProvider.FindTypeMapFor<BusinessModels.User, DataModels.User>()
                                    .GetPropertyMap(opts.DestinationMember.Name)?.DestinationMember;
                                return destinationMember != null ? context.Mapper.Map(srcMember, dest, srcMember.GetType(), destinationMember.PropertyType) : srcMember;
                            });
                        });
                });
                IMapper mapper = config.CreateMapper();
                DataModels.User dataModel = mapper.Map<DataModels.User>(businessModel);
                return dataModel;
            }
            return null;
        }*/
        /*public dynamic ConvertDataModelToBusinessModel(dynamic dataModel)
        {
            PropertyInfo[] properties = dataModel.GetType().GetProperties();
            // Iterate over the properties
            foreach (PropertyInfo property in properties)
            {
                // Get the value of the property
                object value = property.GetValue(dataModel);
                MapperConfiguration config = new MapperConfiguration(cfg => cfg.CreateMap<DataModels.User, BusinessModels.User>());
                IMapper mapper = config.CreateMapper();
                DataModels.User businessModel = mapper.Map<DataModels.User>(dataModel);

            }
            return null;
        }*/

    }
}
