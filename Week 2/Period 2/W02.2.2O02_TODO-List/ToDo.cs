class ToDo
{
    public List<Task> TaskList;
    public ToDo() => TaskList = [];
    public void AddTask(string name) => TaskList.Add(new(name));
    public Task? GetTask(string name)
    {
        foreach (Task task in TaskList){ if (task.Name == name) { return task; } }
        return null;
    }
    public string Report()
    {
        string returnString = "";
        foreach (Task task in TaskList)
        {
            returnString += (returnString.Length > 0) ? "\n" + task.Info() : task.Info();
        }
        return returnString;
    }
}
