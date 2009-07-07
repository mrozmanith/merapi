/////////////////////////////////////////////////////////////////////////////////////
//
//  This program is free software; you can redistribute it and/or modify 
//  it under the terms of the GNU Lesser General Public License as published 
//  by the Free Software Foundation; either version 3 of the License, or (at 
//  your option) any later version.
//
//  This program is distributed in the hope that it will be useful, but 
//  WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
//  or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public 
//  License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License 
//  along with this program; if not, see <http://www.gnu.org/copyleft/lesser.html>.
//
/////////////////////////////////////////////////////////////////////////////////////

using merapi.messages;
using System;
using log4net;
using merapi_core_cs;

namespace merapi.systemexecute.messages
{

    /**
     *  The <code>SystemExecuteMessage</code> class is a sub class of <code>Message</code> 
     *  that signals a system execute request from the UI layer.
     * 
     *  @see merapi.Bridge;
     *  @see merapi.messages.IMessage;
     *  @see merapi.messages.Message
     */
    public class SystemExecuteMessage : Message
    {
        //--------------------------------------------------------------------------
        //
        //  Static variables
        //
        //--------------------------------------------------------------------------

        /**
         *  @private 
         * 
         *  An instance of the log4net logger to handle the logging.
         */
        private static readonly ILog __logger = LogManager.GetLogger( typeof( SystemExecuteMessageHandler ) );
        
        
        //--------------------------------------------------------------------------
        //
        //  Constants
        //
        //--------------------------------------------------------------------------

        /**
         *  Message type for a system execute command.
         */
        public const string SYSTEM_EXECUTE = "systemExecute";


        //--------------------------------------------------------------------------
        //
        //  Constructor
        //
        //--------------------------------------------------------------------------

        /**
         *  Constructor.
         */
        public SystemExecuteMessage() : base()
        {
            __logger.Debug( LoggingConstants.METHOD_BEGIN );
            __logger.Debug( LoggingConstants.METHOD_END );
        }


        //--------------------------------------------------------------------------
        //
        //  Properties
        //
        //--------------------------------------------------------------------------

        //----------------------------------
        //  args
        //----------------------------------

        /**
         *  A set of args to use as the system execute parameters
         */
        public string[] args
        {
            get
            {
                Object[] data = (Object[])base.data;
                String[] args = new String[ data.Length ];
                for ( int i = 0; i < data.Length; i++ )
                {
                    args[ i ] = (String)data[ i ];
                }
                return args;
            }
        }
    }
}