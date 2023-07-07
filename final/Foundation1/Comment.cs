class Comment
{
    private string _name;
    private string _comment;
    public Comment(string name, string comment)
    {
        this._name = name;
        this._comment = comment;
    }

    public string GetName()
    {
        return this._name;
    }

    public string GetComment()
    {
        return this._comment;
    }
}