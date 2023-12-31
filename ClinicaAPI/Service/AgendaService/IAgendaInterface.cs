﻿using ClinicaAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IAgendaInterface
{
    Task<ServiceResponse<List<AgendaModel>>> GetAgendaByDate(DateOnly dia);
    Task<ServiceResponse<List<AgendaModel>>> CreateAgenda(AgendaModel novaAgenda);
    Task<ServiceResponse<AgendaModel>> UpdateAgenda(int id, AgendaModel editAgenda);
    Task<ServiceResponse<AgendaModel>> ValidAgenda(AgendaModel testAgenda);
    Task<ServiceResponse<List<AgendaModel>>> GetMultiAgenda(string param);
    Task<ServiceResponse<List<AgendaModel>>> MultiAgenda(int id, string param);

}