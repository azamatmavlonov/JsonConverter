using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JsonConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ConverterContext context = new ConverterContext())
            {
                Address House = new Address()
                {
                    Label = "House",
                    Details = new List<AddressDetail>()
                    {
                        new AddressDetail()
                        {
                            AddressDetailLabel = AddressDetailLabel.GATE_NUMBER,
                            Value = "1"
                        },
                        new AddressDetail()
                        {
                            AddressDetailLabel = AddressDetailLabel.NUMBER_ON_DOOR,
                            Value = "10"
                        }
                    },
                    Lat = "25.2732492030363",
                    Lng = "51.4940999036853",
                    Notes = "Some notes",
                    Phone = "+97421343311",
                    PreferredContactMethod = PreferredContactMethod.PhoneCall
                };

                Address Apartment = new Address()
                {
                    Label = "Apartment",
                    Details = new List<AddressDetail>()
                    {
                        new AddressDetail()
                        {
                            AddressDetailLabel = AddressDetailLabel.BUILDING_NAME,
                            Value = "Modern Office"
                        },
                        new AddressDetail() 
                        {
                            AddressDetailLabel = AddressDetailLabel.ENTRANCE_NUMBER,
                            Value = "1"
                        },
                        new AddressDetail()
                        {
                            AddressDetailLabel = AddressDetailLabel.FLOOR,
                            Value = "13"
                        },
                        new AddressDetail()
                        {
                            AddressDetailLabel = AddressDetailLabel.APARTMENT,
                            Value = "50"
                        }
                    },
                    Lat = "15.2732492030363",
                    Lng = "51.4940999789853",
                    Notes = "Some other notes",
                    Phone = "+97421341233",
                    PreferredContactMethod = PreferredContactMethod.PhoneCall
                };

                Address Office = new Address()
                {
                    Label = "Office",
                    Details = new List<AddressDetail>()
                    {
                        new AddressDetail()
                        {
                            AddressDetailLabel = AddressDetailLabel.BUILDING_NAME,
                            Value = "Hero Office"
                        },
                        new AddressDetail() 
                        {
                            AddressDetailLabel = AddressDetailLabel.FLOOR_NUMBER,
                            Value = "10"
                        },
                        new AddressDetail()
                        {
                            AddressDetailLabel = AddressDetailLabel.WHERE_SHOULD_WE_BRING_DELIVERY,
                            Value = "The Reception"
                        }
                    },
                    Lat = "18.2732492030363",
                    Lng = "17.4940999036853",
                    Notes = "Some notes",
                    Phone = "+97421343300",
                    PreferredContactMethod = PreferredContactMethod.WhatsApp
                };

                Address Other = new Address()
                {
                    Label = "Other",
                    Details = new List<AddressDetail>()
                    {
                        new AddressDetail()
                        {
                            AddressDetailLabel = AddressDetailLabel.ADDRESS_DETAILS,
                            Value = "I am near BIG STADIUM."
                        }
                    },
                    Lat = "10.2101092030363",
                    Lng = "11.1234999036853",
                    Notes = "Some other notes",
                    Phone = "+97421340000",
                    PreferredContactMethod = PreferredContactMethod.PhoneCall
                };
                
                context.Addresses.Add(House);
                context.Addresses.Add(Apartment);
                context.Addresses.Add(Office);
                context.Addresses.Add(Other);
                context.SaveChanges();

                var addresses = context.Addresses.ToList();
                foreach (var addressItem in addresses)
                {
                    Console.WriteLine($"{addressItem.Id}. Location Type: {addressItem.Label}:");
                    
                    foreach (var addressDetail in addressItem.Details)
                    {
                        Console.WriteLine($"\t{addressDetail.AddressDetailLabel}: {addressDetail.Value}");
                    }

                    Console.WriteLine($"\tPhone: {addressItem.Phone}");
                    Console.WriteLine($"\tLatitude: {addressItem.Lng}");
                    Console.WriteLine($"\tLongitude: {addressItem.Lng}");
                    Console.WriteLine($"\tNotes: {addressItem.Notes}");
                    Console.WriteLine($"\tPreferredContactMethod: {addressItem.PreferredContactMethod}\n");

                }
            }
        }
    }
}