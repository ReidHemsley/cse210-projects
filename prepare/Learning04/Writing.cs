using System;

class Writing : Assignment
{
    private string _title = "";

    public Writing(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        string _studentName = GetStudentName();
        return $"{_title} by {_studentName}";
    }
}