using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlaygroundReservations.Models;

namespace PlaygroundReservations.Helpers
{
	
    public static class ModelHelper
    {
        //private const string ITEMS_CONTROLLER = "Items";
        //private const string CONTACTS_CONTROLLER = "Contacts";
        //private const string LOCATIONS_CONTROLLER = "Locations";

        //public static string GetPrimaryControllerName(int objectType)
        //{
        //    string controllerName = string.Empty;
        //    switch(objectType)
        //    {
        //        case 1 : controllerName = ITEMS_CONTROLLER; break;
        //        case 2 : controllerName = CONTACTS_CONTROLLER; break;
        //        case 3: controllerName = LOCATIONS_CONTROLLER; break;
        //        default: controllerName = string.Empty; break;
        //    }

        //    return controllerName;
        //}

        //public static string GetPrimaryControllerName(ObjectTypes objectType)
        //{
        //    string controllerName = string.Empty;
        //    switch (objectType)
        //    {
        //        case ObjectTypes.Item: controllerName = ITEMS_CONTROLLER; break;
        //        case ObjectTypes.Contact: controllerName = CONTACTS_CONTROLLER; break;
        //        case ObjectTypes.Location: controllerName = LOCATIONS_CONTROLLER; break;
        //        default: controllerName = string.Empty; break;
        //    }

        //    return controllerName;
        //}

        //public static string GetPrimaryControllerName(ObjectDetail objectDetail)
        //{
        //    ObjectTypes objectType = GetObjectType(objectDetail);
        //    string controllerName = GetPrimaryControllerName(objectType);

        //    return controllerName;
        //}

        //public static ObjectTypes GetObjectType(ObjectDetail objectDetail)
        //{
        //    return (objectDetail is Item) ? ObjectTypes.Item : (objectDetail is Contact) ? ObjectTypes.Contact : (objectDetail is Location) ? ObjectTypes.Location : ObjectTypes.Location;
        //}

        //public static int GetModelType(ObjectDetail objectDetail)
        //{
        //    ObjectTypes objType = GetObjectType(objectDetail);
        //    int objectType = (int)objType;

        //    return objectType;
        //}

    }
}