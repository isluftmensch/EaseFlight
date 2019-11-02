﻿using EaseFlight.BLL.Interfaces;
using EaseFlight.Common.Utilities;
using EaseFlight.DAL.Entities;
using EaseFlight.DAL.Interfaces;
using EaseFlight.DAL.UnitOfWorks;
using EaseFlight.Models.EntityModels;
using System.Collections.Generic;
using System.Linq;

namespace EaseFlight.BLL.Services
{
    public class PassengerTicketService : BaseService, IPassengerTicketService
    {
        #region Properties
        private IPassengerTicketRepository PassengerTicketRepository { get; set; }
        #endregion

        #region Constructors
        public PassengerTicketService(IUnitOfWork unitOfWork,
            IPassengerTicketRepository passengerTicketRepository) : base(unitOfWork)
        {
            this.PassengerTicketRepository = passengerTicketRepository;
        }
        #endregion

        #region Functions
        public IEnumerable<PassengerTicketModel> FindAll()
        {
            var modelList = this.PassengerTicketRepository.FindAll();
            var result = modelList.Select(model => this.CreateViewModel(model));

            return result;
        }
        #endregion

        #region Model Functions
        public PassengerTicketModel CreateViewModel(PassengerTicket model)
        {
            PassengerTicketModel viewModel = null;

            if (model != null)
            {
                viewModel = new PassengerTicketModel();
                CommonMethods.CopyObjectProperties(model, viewModel);
            }

            return viewModel;
        }
        #endregion
    }
}