﻿
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public class JsonPolicySerializer
{
    public Policy GetPolicyFromJsonString(string jsonString)
    {
        return JsonConvert.DeserializeObject<Policy>(jsonString,
            new StringEnumConverter());
    }
}
