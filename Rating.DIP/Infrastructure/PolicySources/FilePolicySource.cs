﻿

public class FilePolicySource : IPolicySource
{
    public string GetPolicyFromSource()
    {
        return File.ReadAllText("policy.json");
    }
}

