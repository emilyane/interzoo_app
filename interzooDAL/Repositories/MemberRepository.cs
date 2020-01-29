using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using interzooDAL.Models;

namespace interzooDAL.Repositories


//    SELECT
//FROM[Animal Parent] INNER JOIN
//                         Member ON[Animal Parent].idAnimalParent = Member.idAnimalParent INNER JOIN
//                        Veterinarian ON Member.idVeterinarian = Veterinarian.idVeterinarian INNER JOIN
//                        Volunteer ON Member.idVolunteer = Volunteer.idVolunteer INNER JOIN

//                        Zookeeper ON Member.idZookeeper = Zookeeper.idZookeeper

{
    public class MemberRepository : BaseRepository<Member, int>
    {
      
        public MemberRepository(string Cnstr) : base(Cnstr)
        {
            SelectOneCommand = "Select * from Member where idMember=@idMember";
            SelectAllCommand = "Select * from Member";
            InsertCommand = @"INSERT INTO Member (idVeterinarian, idVolunteer, idZookeeper, idAnimalParent, isAdmin) 
                                OUTPUT inserted.idMember VALUES(@idVolunteer, @idVeterinarian, @idZookeeper, @AnimalParent, @idAdmin)";

            UpdateCommand = @"UPDATE  Member
                           SET idVeterinarian=@idVeterinarian, idVolunteer=@idVolunteer, idZookeeper=@idZookeeper, idAnimalParent=@AnimalParent, isAdmin= @isAdmin
                         WHERE IdMember = @idMember;";
            DeleteCommand = @"Delete from  Member  WHERE IdMember = @idMember;";
        }

        public Member VerifLogin(Member member)
        {
            //SelectOneCommand = "Select * from Member where Email=@email and Password=@password"; //Problem!!!
            return base.getOne(Map, MapToDico(member));
        }

        public override Member GetZookeeper(int id)
        {
            SelectOneCommand = "Select * from Member inner join Zookeeper on Membre.IdZookeeper = Zookeeper.id WHERE Member.idZookeeper=@id";
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("idZookeeper", id);
            return base.getOne(Map, QueryParameters);
        }

        public override Member GetVolunteer(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("idVolunteer", id);
            return base.getOne(Map, QueryParameters);
        }
        public override IEnumerable<Member> GetAll()
        {
            return base.getAll(Map);
        }

        public override Member GetOne(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("idMember", id);
            return base.getOne(Map, QueryParameters);
        }

        public override Member Insert(Member toInsert)
        {
            Dictionary<string, object> Parameters = MapToDico(toInsert);
            int id = base.Insert(Parameters);
            toInsert.IdMember = id;
            return toInsert;
        }

        //internal IEnumerable<Zookeeper> GetAllFromGroup(int id)
        //{
        //    SelectAllCommand = "Select * from Zookeeper inner join MembreGroupe Mg on Membre.IdMEmbre= Mg.IdMembre WHERE Mg.idGroupe=@id";
        //    Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
        //    QueryParameters.Add("id", id);
        //    return base.getAll(Map, QueryParameters);

        //}

        public override bool Update(Member toUpdate)
        {
            Dictionary<string, object> Parameters = MapToDico(toUpdate);
            return base.Update(Parameters);

        }

        public override bool Delete(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("@idMember", id);
            return base.Delete(QueryParameters);

        }

        //public IEnumerable<Groupe> GetAllFromMembre(int idMembre, bool isAdmin = false)
        //{

        //    SelectAllCommand = @"SELECT        Groupe.*
        //    FROM            Membre INNER JOIN
        //                 MembreGroupe ON Membre.IdMembre = MembreGroupe.IdMembre INNER JOIN
        //                 Groupe ON MembreGroupe.IdGroupe = Groupe.IdGroupe INNER JOIN
        //                 Evenement ON Groupe.IdEvenement = Evenement.IdEvenement
        //    WHERE        (Membre.IdMembre = @IdMembre) ";
        //    if (isAdmin)
        //    {
        //        SelectAllCommand += " AND(MembreGroupe.Admin = 1)";
        //    }
        //    Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
        //    QueryParameters.Add("IdMembre", idMembre);

        //    return base.getAll(Map, QueryParameters);
        //}



        #region Mappers
        private Dictionary<string, object> MapToDico(Member toInsert)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p["idMember"] = toInsert.IdMember;
            p["isAdmin"] = toInsert.IsAdmin;
            return p;
        }

        private Member Map(SqlDataReader arg)
        {
            return new Member()
            {
                IdMember = (int)arg["idMember"]
               
            };
        }
        #endregion
    }
}



