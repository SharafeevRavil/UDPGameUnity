﻿using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class PortsAuthData
{
    public PortsAuthData(int clientPort, int serverPort)
    {
        this.clientPort = clientPort;
        this.serverPort = serverPort;
    }
    
    public int serverPort;
    public int clientPort;
}

[Serializable]
public class GameData
{
    public List<PlayerData> PlayerDatas;

    public GameData(List<PlayerData> playerDatas)
    {
        PlayerDatas = playerDatas;
    }

    public GameData()
    {
        PlayerDatas = new List<PlayerData>();
    }
}

[Serializable]
public class PlayerData
{
    public string Guid;
    public float PosX;
    public float PosY;
    public float PosZ;

    public PlayerData(string guid, float posX, float posY, float posZ)
    {
        Guid = guid;
        PosX = posX;
        PosY = posY;
        PosZ = posZ;
    }

    public PlayerData()
    {
    }
}