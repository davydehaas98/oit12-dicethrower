﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toets3Application
{
    public class MessageBuilder
    {
        private string partlyMessage;
        private Queue<string> messages;

        public char MessageBeginMarker { get; private set; }
        public char MessageEndMarker { get; private set; }

        public int MessageCount
        {
            get
            {
                return messages.Count;
            }
        }

        public MessageBuilder(char messageBeginMarker, char messageEndMarker)
        {
            MessageBeginMarker = messageBeginMarker;
            MessageEndMarker = messageEndMarker;
            messages = new Queue<string>();
            partlyMessage = null;
        }

        public void Add(string data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            string message;
            bool messageStarted;
            if (partlyMessage != null)
            {
                message = partlyMessage;
                messageStarted = true;
                partlyMessage = null;
            }
            else
            {
                message = "";
                messageStarted = false;
            }

            foreach(char character in data)
            {
                if(messageStarted)
                {
                    if (character != MessageEndMarker)
                    {
                        message += character;
                    }
                    else
                    {
                        messages.Enqueue(message);
                        message = "";
                        messageStarted = false;
                    }
                }
                else
                {
                    if(character == MessageBeginMarker)
                    {
                        messageStarted = true;
                    }
                }
            }
            if(messageStarted)
            {
                partlyMessage = message;
            }
        }

        public string GetNextMessage()
        {
            if (messages.Count > 0)
            {
                return messages.Dequeue();
            }
            return null;
        }

        public void Clear()
        {
            messages.Clear();
            partlyMessage = null;
        }
    }
}
