﻿namespace BO;

/// <summary>
/// Engineer main logical entity for Engineer List screen.
/// </summary>
/// <param name="Id">Unique ID number</param>
/// <param name="Name">The name of the engineer</param>
/// <param name="Email">Email address of the engineer</param>
/// <param name="Level">Engineer level</param>
internal class EngineerInList
{
    private DO.EngineerExperience level;

    public EngineerInList(int id, string name, string? email, DO.EngineerExperience level)
    {
        Id = id;
        Name = name;
        Email = email;
        this.level = level;
    }

    public int Id { get; init; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public EngineerExperience Level { get; set; }
    public override string ToString() => Tools.ToStringProperty(this);

}
