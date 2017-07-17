using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse 

{
    public class Menu
    {
        private IDictionary<string, IDevice> MyDevices = new Dictionary<string, IDevice>();
        public ICreateDevice NewDevice { set; get; }

        public void Show()
        {
            NewDevice = new CreateDevice();
            MyDevices.Add("TV1", NewDevice.CreateTV());
            MyDevices.Add("Radio1", NewDevice.CreateRadio());
            MyDevices.Add("Lamp1", NewDevice.CreateLamp());

            while (true)
            {
                Console.Clear();
                foreach (var device in MyDevices)
                {
                    Console.WriteLine("Name: " + device.Key + device.Value);
                }
                Console.WriteLine();
                Console.Write("Enter the command: ");
                string[] commands = Console.ReadLine().Split(' ');
                
                if (commands.Length == 1 && commands[0].ToLower() == "exit")
                {
                    return;
                }
                if (commands.Length == 1)
                {
                    Help();
                    continue;
                }
                if (commands.Length == 2 && commands[0].ToLower() == "add")
                {
                    Help();
                    continue;
                }
                if (commands[0].ToLower() == "add" && !MyDevices.ContainsKey(commands[2]))// add TV TV1
                {
                    if (commands[1] == "TV")
                    {
                        MyDevices.Add(commands[2], NewDevice.CreateTV());
                        continue;
                    }
                    else if (commands[1] == "Radio")
                    {
                        MyDevices.Add(commands[2], NewDevice.CreateRadio());
                        continue;
                    }
                    else if (commands[1] == "Lamp")
                    {
                        MyDevices.Add(commands[2], NewDevice.CreateLamp());
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nUnknown device type!\nPress any key to continue.");
                        Console.ReadKey();
                        continue;
                    }
                }
                if (commands[0].ToLower() == "add" && MyDevices.ContainsKey(commands[2]))
                {
                    Console.WriteLine("\nError!\nDevice with the same name already exists.\nPress any key to continue.");
                    Console.ReadKey();
                    continue;
                }
                if (commands[0].ToLower() == "delete" && !MyDevices.ContainsKey(commands[1]))
                {
                    Console.WriteLine("\nDevice with the same name does not exist!");
                    Console.ReadKey();
                    continue;
                }
                if (commands.Length == 2 && !MyDevices.ContainsKey(commands[1]))
                {
                    Console.WriteLine("\nDevice with the same name does not exist!");
                    Console.ReadKey();
                    continue;
                }
                else if (commands.Length == 3 && !MyDevices.ContainsKey(commands[2]))
                {
                    Console.WriteLine("\nDevice with the same name does not exist!");
                    Console.ReadKey();
                    continue;
                }
                if (commands.Length == 2 && commands[0] == "delete" || commands[0] == "on" || commands[0] == "off" && MyDevices.ContainsKey(commands[1]))// on TV1
                {
                    switch (commands[0].ToLower())
                    {
                        case "delete":
                            MyDevices.Remove(commands[1]);
                            break;
                        case "on":
                            if (MyDevices[commands[1]].State)
                            {
                                Console.WriteLine("\nDevice is already working!");
                                Console.ReadKey();
                            }
                            else
                            {
                                MyDevices[commands[1]].On();
                            }
                            break;
                        case "off":
                            if (MyDevices[commands[1]].State)
                            {
                                MyDevices[commands[1]].Off();
                            }
                            else
                            {
                                Console.WriteLine("\nDevice is already off!");
                                Console.ReadKey();
                            }
                            break;
                    }
                }
                else if (commands.Length == 2 && MyDevices.ContainsKey(commands[1]) && MyDevices[commands[1]].State == true)// next TV1
                {
                    switch (commands[0].ToLower())
                    {
                        case "next":
                            if (MyDevices[commands[1]] is IDeviceChannel)
                            {
                                IDeviceChannel device = (IDeviceChannel)MyDevices[commands[1]];
                                device.NextChannel();
                            }
                            break;
                        case "previouse":
                            if (MyDevices[commands[1]] is IDeviceChannel)
                            {
                                IDeviceChannel device = (IDeviceChannel)MyDevices[commands[1]];
                                device.PreviouseChannel();
                            }
                            break;
                        case "last":
                            if (MyDevices[commands[1]] is IDeviceChannel)
                            {
                                IDeviceChannel device = (IDeviceChannel)MyDevices[commands[1]];
                                device.LastChannel();
                            }
                            break;
                        case "louder":
                            if (MyDevices[commands[1]] is IDeviceSound)
                            {
                                IDeviceSound device = (IDeviceSound)MyDevices[commands[1]];
                                device.Louder();
                            }
                            break;
                        case "quiet":
                            if (MyDevices[commands[1]] is IDeviceSound)
                            {
                                IDeviceSound device = (IDeviceSound)MyDevices[commands[1]];
                                device.Quiet();
                            }
                            break;
                        case "mute":
                            if (MyDevices[commands[1]] is IDeviceSound)
                            {
                                IDeviceSound device = (IDeviceSound)MyDevices[commands[1]];
                                device.Mute();
                            }
                            break;
                        case "unmute":
                            if (MyDevices[commands[1]] is IDeviceSound)
                            {
                                IDeviceSound device = (IDeviceSound)MyDevices[commands[1]];
                                device.Unmute();
                            }
                            break;
                        case "brighter":
                            if (MyDevices[commands[1]] is IDeviceBrightness)
                            {
                                IDeviceBrightness device = (IDeviceBrightness)MyDevices[commands[1]];
                                device.UpBrightness();
                            }
                            break;
                        case "darker":
                            if (MyDevices[commands[1]] is IDeviceBrightness)
                            {
                                IDeviceBrightness device = (IDeviceBrightness)MyDevices[commands[1]];
                                device.Darker();
                            }
                            break;
                        default:
                            Help();
                            break;
                    }
                }
                else if (commands.Length == 2 && MyDevices.ContainsKey(commands[1]) && MyDevices[commands[1]].State == false)
                {
                    switch (commands[0].ToLower())
                    {
                        case "next":
                        case "previouse":
                        case "last":
                        case "louder":
                        case "quiet":
                        case "mute":
                        case "unmute":
                        case "play":
                        case "pause":
                        case "stop":
                        case "randomsong":
                        case "changeinput":
                        case "warmer":
                        case "colder":
                        case "mode":
                        case "brighter":
                        case "darker":
                            Console.WriteLine("\nFirst, turn on the device!");
                            Console.ReadKey();
                            break;
                        default:
                            Help();
                            break;
                    }
                }
                else if (commands.Length == 3 && MyDevices.ContainsKey(commands[2]) && MyDevices[commands[2]].State == true)// пример проверить  setchannel  32  TV1
                {
                    if (MyDevices[commands[2]] is IDeviceChannel)
                    {
                        IDeviceChannel device = (IDeviceChannel)MyDevices[commands[2]];
                        int channel;
                        Int32.TryParse(commands[1], out channel);
                        switch (commands[0].ToLower())
                        {
                            case "setchannel":
                                device.SetChannel(channel);
                                break;
                            default:
                                Help();
                                continue;
                        }
                    }
                }
                else if (commands.Length == 3 && MyDevices.ContainsKey(commands[2]) && MyDevices[commands[2]].State == false)
                {
                    if (MyDevices[commands[2]] is IDeviceChannel)
                    {
                        switch (commands[0].ToLower())
                        {
                            case "setchannel":
                                Console.WriteLine("\nFirst, turn on the device!");
                                Console.ReadKey();
                                break;
                            default:
                                Help();
                                continue;
                        }
                    }
                }
            }
        }

        private static void Help()
        {
            Console.WriteLine();
            Console.WriteLine("All commands:");
            Console.WriteLine("\t- help - commands list");
            Console.WriteLine("\t- exit - exit");
            Console.WriteLine();

            Console.WriteLine("You can add new devices:");
            Console.WriteLine("\t- TV\n\t- Radio\n\t- Lamp");
            Console.WriteLine();

            Console.WriteLine("Commands for all devices:");
            Console.WriteLine("\t- delete - delete device");
            Console.WriteLine("\t- on - on device");
            Console.WriteLine("\t- off - off device");
            Console.WriteLine();

            Console.WriteLine("Commands for TV:");
            Console.WriteLine("\t- next - next channel");
            Console.WriteLine("\t- previouse - previouse channel");
            Console.WriteLine("\t- last - last channel");
            Console.WriteLine("\t- setchannel - set your channel");
            Console.WriteLine("\t- louder - increases the sound");
            Console.WriteLine("\t- quiet - decreases the sound");
            Console.WriteLine("\t- mute - mute");
            Console.WriteLine("\t- unmute - unmute");
            Console.WriteLine("\t- brighter -   increases the brightness");
            Console.WriteLine("\t- darker -  decreases the brightness");
            Console.WriteLine();

            Console.WriteLine("Commands for Radio:");
            Console.WriteLine("\t- next - next channel");
            Console.WriteLine("\t- previouse - previouse channel");
            Console.WriteLine("\t- last - last channel");
            Console.WriteLine("\t- setchannel - set your channel");
            Console.WriteLine("\t- louder - increases the sound");
            Console.WriteLine("\t- quiet - decreases the sound");
            Console.WriteLine("\t- mute - mute");
            Console.WriteLine("\t- unmute - unmute");
            Console.WriteLine();

            Console.WriteLine("Commands for Lamp:");
            Console.WriteLine("\t- brighter -   increases the brightness");
            Console.WriteLine("\t- darker -  decreases the brightness");
            Console.WriteLine();


            Console.WriteLine();
            Console.Write("Press any key to continue... ");
            Console.ReadKey();
        }
    }
}
