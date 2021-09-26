using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Mono.Data.Sqlite;
using System;
using System.Data;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Networking;


public class DataBase : MonoBehaviour
{
    public SqliteConnection _dbconn;
    private string _path, _conn;




    private void Awake()
    {


        if (Application.platform == RuntimePlatform.Android)
        {
            Debug.Log("!!!!!!!!!!!It is drod");
            _path = GetPath();
            if (!File.Exists(_path))
            {
                Debug.Log("!!!!!!!!!!!!!!try to install db");
                var loadingRequest = UnityWebRequest.Get(Path.Combine(Application.streamingAssetsPath, "DB.bytes"));
                loadingRequest.SendWebRequest();
                while (!loadingRequest.isDone) { }

                File.WriteAllBytes(Path.Combine(Application.persistentDataPath, "DB.bytes"), loadingRequest.downloadHandler.data);
            }
            else if (File.Exists(_path)) Debug.Log("!!!!!!!!!!!!!! db is on droid");


        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {

            _path = GetPath();

            if (!File.Exists(_path))
            {
                _path = Application.streamingAssetsPath + "/DB.bytes";

                File.Copy(_path, Application.persistentDataPath + "/DB.bytes");

            }


        }
        else
        {
            _path = GetPath();

            if (!File.Exists(_path))
            {
                _path = Application.streamingAssetsPath + "/DB.bytes";

                File.Copy(_path, Application.persistentDataPath + "/DB.bytes");

            }
        }


    }

    private string GetPath()
    {
        _path = Path.Combine(Application.persistentDataPath, "DB.bytes");
        return _path;
    }

    public int GetIntData(string _gettingDataType, string _tableName, string _indicatorValue, string _indicatorType)
    {
        int _data = 0;

        _conn = "URI=file:" + _path;

        using (_dbconn = new SqliteConnection(_conn))
        {



            _dbconn.Open(); //Open connection to the database.
            IDbCommand _dbcmd = _dbconn.CreateCommand();
            string _sqlQuery = string.Format("SELECT {0} FROM {1} where {2} ='{3}'", _gettingDataType, _tableName, _indicatorType, _indicatorValue);// table name




            _dbcmd.CommandText = _sqlQuery;
            IDataReader reader = _dbcmd.ExecuteReader();
            while (reader.Read())
            {
                int _value;

                _value = reader.GetInt32(0);

                return _value;

            }
            reader.Close();
            reader = null;
            _dbcmd.Dispose();
            _dbcmd = null;
            _dbconn.Close();
            Debug.Log("Int get error");
            _data = 0;
            return _data;
        }
    }

    public string GetStringData(string _gettingDataType, string _tableName, string _indicatorValue, string _indicatorType)
    {
        string _data = "Null ref";

        _conn = "URI=file:" + _path;

        using (_dbconn = new SqliteConnection(_conn))
        {



            _dbconn.Open(); //Open connection to the database.
            IDbCommand _dbcmd = _dbconn.CreateCommand();
            string _sqlQuery = string.Format("SELECT {0} FROM {1} where {2} ='{3}'", _gettingDataType, _tableName, _indicatorType, _indicatorValue);// table name




            _dbcmd.CommandText = _sqlQuery;
            IDataReader reader = _dbcmd.ExecuteReader();
            while (reader.Read())
            {
                string _value;

                _value = reader.GetString(0);

                return _value;

            }
            reader.Close();
            reader = null;
            _dbcmd.Dispose();
            _dbcmd = null;
            _dbconn.Close();
            Debug.Log("String get error");
            return _data;
        }
    }

    public void UpdateIntData(string _uploadingDataType, int _uploadingDataValue, string _tableName, string _indicatorType, string _indicatorValue)
    {
        string _query;
        SqliteCommand _cmd = new SqliteCommand();

        _query = string.Format("update {0} set {1} = {2} where {3} = \"{4}\"", _tableName, _uploadingDataType, _uploadingDataValue, _indicatorType, _indicatorValue);

        _path = GetPath();
        _dbconn = new SqliteConnection("URI=file:" + _path);
        _dbconn.Open();

        if (_dbconn.State == ConnectionState.Open)
        {
            try
            {
                _cmd = _dbconn.CreateCommand();
                _cmd.CommandText = _query;
                SqliteDataReader _reader = _cmd.ExecuteReader();


            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
        }
    }

    public void UpdataStrinData(string _uploadingValueType, string _uploadingDataValue, string _tableName, string _indicatorType, string _indicatorValue)
    {
        string _query;
        SqliteCommand _cmd = new SqliteCommand();

        _query = string.Format("update {0} set {1} = \'{2}\' where {3} = \"{4}\"", _tableName, _uploadingValueType, _uploadingDataValue, _indicatorType, _indicatorValue);
        _path = GetPath();
        _dbconn = new SqliteConnection("URI=file:" + _path);
        _dbconn.Open();

        if (_dbconn.State == ConnectionState.Open)
        {
            try
            {
                _cmd = _dbconn.CreateCommand();
                _cmd.CommandText = _query;
                SqliteDataReader _reader = _cmd.ExecuteReader();


            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
        }
    }
}
