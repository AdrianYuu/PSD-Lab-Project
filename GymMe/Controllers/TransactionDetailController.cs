﻿using GymMe.Handlers;
using GymMe.Models;
using GymMe.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Controllers
{
	public class TransactionDetailController
	{
		public static Response<List<TransactionDetail>> GetTransactionDetailsByTransactionId(int transacitonId)
		{
			return TransactionDetailHandler.GetTransactionDetailsByTransactionId(transacitonId);
		}
	}
}