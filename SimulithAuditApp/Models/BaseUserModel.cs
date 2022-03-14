﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulithAuditApp.Models
{
  public class BaseUserModel
  {
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string DisplayName { get; set; }

    public BaseUserModel()
    {

    }

    public BaseUserModel(UserModel user)
    {
      Id = user.Id;
      DisplayName = user.DisplayName;
    }
  }
}
