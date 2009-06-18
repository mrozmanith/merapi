﻿////////////////////////////////////////////////////////////////////////////////
//
//  $license
//
////////////////////////////////////////////////////////////////////////////////

using System;
using merapi;
using merapi.messages;
using Merapi.Handlers;

namespace Merapi
{
    class Bootstrap
    {
        //--------------------------------------------------------------------------
        //
        //  Class Methods
        //
        //--------------------------------------------------------------------------

        /**
         *  The main method that starts the bridge.
         */	
        static void Main(string[] args)
        {
            System.Console.WriteLine( "Bootstrap" );

            PolicyServer.Start();

            Bridge b = Bridge.GetInstance();

            HelloWorldListener hwl = new HelloWorldListener();

            System.Console.ReadLine();
        }
    }

    class HelloWorldListener : MessageHandler
    {
        public HelloWorldListener()
            : base( "hwType" )
        {
        }
            

        public override void HandleMessage( IMessage message )
        {
            System.Console.WriteLine( "Recv'd message: " + message.data );

            Message m = new Message();
            m.type = message.type;
            m.data = message.data;
            m.send();
        }
    }
}
