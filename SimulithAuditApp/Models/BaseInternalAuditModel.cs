﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulithAuditApp.Models
{
  public class BaseInternalAuditModel
  {
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Audit { get; set; }
    public BaseInternalAuditModel()
    {

    }

    public BaseInternalAuditModel(InternalAuditModel auditModel)
    {
      Id = auditModel.Id;
      Audit = auditModel.Audit;
    }
  }
}
