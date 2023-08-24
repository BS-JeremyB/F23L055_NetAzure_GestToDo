﻿using F23L055_GestToDo.Dal.Entities;
using F23L055_GestToDo.Dal.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Dal.Mappers
{
    internal static class DataRecordExtensions
    {
        internal static Tache ToTache(this IDataRecord record)
        {
            return new Tache()
            {
                Id = (int)record["Id"],
                Titre = (string)record["Titre"],
                Finalise = (bool)record["Finalise"],
                Responsable = (int)record["Responsable"]
            };
        }

        internal static User ToUser(this IDataRecord record)
        {
            return new User()
            {
                Id = (int)record["Id"],
                Email = (string)record["Email"],
                Role = (Roles)Enum.ToObject(typeof(Roles), (int)record["Role"])
            };
        }
    }
}
