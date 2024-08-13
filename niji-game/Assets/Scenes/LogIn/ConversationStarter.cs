using Ervean.Utilities.Talking;
using Ervean.Utilities.Talking.Conversations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ervean.NijiGame.Login
{
    public class ConversationStarter : MonoBehaviour
    {
        [SerializeField] private TalkingManager talkingManager;
        private ConversationDatabase conversationDatabase;

        private void Awake()
        {
            conversationDatabase = ConversationDatabase.instance;
            foreach(TalkingSettings ts in conversationDatabase.GetConversation(0).Talking)
            {
                talkingManager.Talk(ts);
            }
        }
    }
}