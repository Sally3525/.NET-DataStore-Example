using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_person", DwStyle.Default)]
    [Table("Person", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.Person\" ) COLUMN(NAME=\"Person.Person.businessentityid\") COLUMN(NAME=\"Person.Person.persontype\") COLUMN(NAME=\"Person.Person.namestyle\") COLUMN(NAME=\"Person.Person.title\") COLUMN(NAME=\"Person.Person.firstname\") COLUMN(NAME=\"Person.Person.middlename\") COLUMN(NAME=\"Person.Person.lastname\") COLUMN(NAME=\"Person.Person.suffix\") COLUMN(NAME=\"Person.Person.emailpromotion\") COLUMN(NAME=\"Person.Person.modifieddate\")WHERE(    EXP1 =\"Person.Person.BusinessEntityID\"   OP =\"=\"    EXP2 =\":ai_id\" ) ) ARG(NAME = \"ai_id\" TYPE = number) ")]
    #endregion
    [DwParameter("ai_id", typeof(decimal?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Person
    {
        [Key]
        [DefaultValue("0")]
        public int Businessentityid { get; set; }

        [DwChild("Persontype", "Typedesc", typeof(D_Dddw_Persontype))]
        public string Persontype { get; set; }

        [SqlDefaultValue("((0))")]
        public bool Namestyle { get; set; }

        public string Title { get; set; }

        public string Firstname { get; set; }

        public string Middlename { get; set; }

        public string Lastname { get; set; }

        public string Suffix { get; set; }

        [SqlDefaultValue("((0))")]
        public int Emailpromotion { get; set; }

        [SqlDefaultValue("(getdate())")]
        public DateTime Modifieddate { get; set; }

    }

}
