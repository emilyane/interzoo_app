using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using interzooDAL.Models;

namespace interzooDAL.Repositories
{
    public class VolunteerRepository : BaseRepository<Volunteer, int>
    {
        public VolunteerRepository(string Cnstr) : base(Cnstr)
        {
            SelectOneCommand = "Select * from Volunteer where idVolunteer=@idVolunteer";
            SelectAllCommand = "Select * from Volunteer";
            InsertCommand = @"INSERT INTO Volunteer (FirstName, LastName,
            email, phone, birthday, photo, password) 
                                OUTPUT inserted.idVolunteer VALUES(@FirstName, @LastName, 
            @email, @phone, @birthday, @photo, @password)";

            UpdateCommand = @"UPDATE  Volunteer
                           SET FirstName = @FirstName,  LastName = @LastName, Birthday = @birthday, Phone = @phone, Email = @email,  Password = @password>
                         WHERE IdVolunteer = @idVolunteer;";
            DeleteCommand = @"Delete from  Volunteer  WHERE IdVolunteer = @idVolunteer;";
        }

        public Volunteer VerifLogin(Volunteer volunteer)
        {
            SelectOneCommand = "Select * from Volunteer where Email=@email and Password=@password";
            return base.getOne(Map, MapToDico(volunteer));
        }

        public override IEnumerable<Volunteer> GetAll()
        {
            return base.getAll(Map);
        }

        public override Volunteer GetOne(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("idVolunteer", id);
            return base.getOne(Map, QueryParameters);
        }

        public override Volunteer Insert(Volunteer toInsert)
        {
            Dictionary<string, object> Parameters = MapToDico(toInsert);
            int id = base.Insert(Parameters);
            toInsert.IdVolunteer = id;
            return toInsert;
        }

        //internal IEnumerable<Zookeeper> GetAllFromGroup(int id)
        //{
        //    SelectAllCommand = "Select * from Zookeeper inner join MembreGroupe Mg on Membre.IdMEmbre= Mg.IdMembre WHERE Mg.idGroupe=@id";
        //    Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
        //    QueryParameters.Add("id", id);
        //    return base.getAll(Map, QueryParameters);

        //}

        public override bool Update(Volunteer toUpdate)
        {
            Dictionary<string, object> Parameters = MapToDico(toUpdate);
            return base.Update(Parameters);

        }

        public override bool Delete(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("@idVolunteer", id);
            return base.Delete(QueryParameters);

        }


        #region Mappers
        private Dictionary<string, object> MapToDico(Volunteer toInsert)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p["idVolunteer"] = toInsert.IdVolunteer;
            p["FirstName"] = toInsert.FirstName;
            p["LastName"] = toInsert.LastName;
            p["birthday"] = toInsert.Birthday;
            p["phone"] = toInsert.Phone;
            p["email"] = toInsert.Email;
            p["password"] = toInsert.HashMDP;
            return p;
        }

        private Volunteer Map(SqlDataReader arg)
        {
            return new Volunteer()
            {
                IdVolunteer = (int)arg["idVolunteer"],
                FirstName = arg["FirstName"].ToString(),
                LastName = arg["LastName"].ToString(),
                Email = arg["email"].ToString(),
                Phone = (int)arg["phone"],
                Birthday = (DateTime)arg["birthday"]
                //casting 

                //WE CAN'T STORE PASSWORD FROM DB
                // MotDePasse= arg["MotDePasse"].ToString()
            };
        }
        #endregion
    }
}


