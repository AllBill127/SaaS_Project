﻿using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PSP.Models;

public class EmployeeShiftsModel
{
    [JsonProperty("employeeShiftsId")]
    public Guid EmployeeShiftsId { get; set; }

    [JsonProperty("employeeId")]
    [Required]
    public Guid EmployeeId { get; set; }

    [JsonProperty("shiftId")]
    [Required]
    public Guid ShiftId { get; set; }

    [JsonProperty("workDay")]
    [Required]
    public DateOnly WorkDay { get; set; }

    public EmployeeShift Convert()
    {
        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<EmployeeShiftsModel, EmployeeShift>()
            .ForMember(dest => dest.WorkDay, act => act.Ignore())
            .ForMember(dest => dest.EmployeeShiftId, act => act.Ignore()));
        var mapper = new Mapper(config);
        EmployeeShift employeeShift = mapper.Map<EmployeeShiftsModel, EmployeeShift>(this);

        employeeShift.WorkDay = this.WorkDay.Convert();
        try
        {
            employeeShift.EmployeeShiftId = Guid.Parse(this.EmployeeShiftsId.ToString());
        }
        catch (ArgumentNullException)
        {
            employeeShift.EmployeeShiftId = new Guid();
        }
        catch (FormatException)
        {
            employeeShift.EmployeeShiftId = new Guid();
        }

        return employeeShift;
    }

    public static EmployeeShiftsModel Convert( EmployeeShift employeeShift)
    {
        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<EmployeeShift, EmployeeShiftsModel>()
            .ForMember(dest => dest.WorkDay, act => act.Ignore()));
        var mapper = new Mapper(config);
        EmployeeShiftsModel employeeShiftsModel = mapper.Map<EmployeeShift, EmployeeShiftsModel>(employeeShift);
        employeeShiftsModel.WorkDay = DateOnly.Convert(employeeShift.WorkDay);
        return employeeShiftsModel;
    }

    public static List<EmployeeShiftsModel> Convert(List<EmployeeShift> employeeShifts)
    {
        List<EmployeeShiftsModel> employeeShiftsModels = new List<EmployeeShiftsModel>();
        employeeShifts.ForEach(shift => employeeShiftsModels.Add(Convert(shift)));
        return employeeShiftsModels;
    }
}
