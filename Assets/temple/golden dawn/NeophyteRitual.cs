﻿using UnityEngine;
using System.Collections;
using System;
using System.Linq;

public class NeophyteRitual : MonoBehaviour
{

    public ScriptAction fastForwardTo;

    public AudioClip knock;
    public AudioClip[] clips;
    
    public GameObject hierophantPrefab, hiereusPrefab, hegemonPrefab, keruxPrefab, stolistesPrefab, dadouchosPrefab;
    public GameObject imperatorPrefab, cancellariusPrefab, pastHierophantPrefab, praemonstratorPrefab;


    public GameObject doorPrefab, thronePrefab, altarPrefab;
    public GameObject blackPillarPrefab, whitePillarPrefab, bannerOfTheEastPrefab, bannerOfTheWestPrefab;

    private GameObject hierophant, hiereus, hegemon, kerux, stolistes, dadouchos;
    private Transform marks;

    private ScriptActionQueue queue = new ScriptActionQueue();

    private AudioClip getClip(int id)
    {
        return clips[id-1];
    }

    // Use this for initialization
    void Start()
    {
        hideMarks();

        var ground = transform.Find("Ground");
        marks = ground.transform.FindChild("Marks");

        hierophant = addActor(hierophantPrefab, "Hierophant Start");
        hiereus = addActor(hiereusPrefab, "Hiereus Start");
        hegemon = addActor(hegemonPrefab, "Hegemon Start");
        kerux = addActor(keruxPrefab, "Kerux Start");
        stolistes = addActor(stolistesPrefab, "Stolistes Start");
        dadouchos = addActor(dadouchosPrefab, "Dadouchos Start");

        addActor(doorPrefab, "Door");
        addActor(altarPrefab, "Altar");
        addActor(bannerOfTheEastPrefab, "Banner of the East");
        addActor(bannerOfTheWestPrefab, "Banner of the West");
        addActor(blackPillarPrefab, "Black Pillar");
        addActor(whitePillarPrefab, "White Pillar");

        addThrone(thronePrefab, "Hierophant Start");
        addThrone(thronePrefab, "Hiereus Start");
        addThrone(thronePrefab, "Hegemon Start");
        addThrone(thronePrefab, "Stolistes Start");
        addThrone(thronePrefab, "Dadouchos Start");

        addThrone(thronePrefab, "Imperator Start");
        addThrone(thronePrefab, "Cancellarius Start");
        addThrone(thronePrefab, "Past Hierophant Start");
        addThrone(thronePrefab, "Praemonstrator Start");

        addActor(imperatorPrefab, "Imperator Start");
        addActor(cancellariusPrefab, "Cancellarius Start");
        addActor(pastHierophantPrefab, "Past Hierophant Start");
        addActor(praemonstratorPrefab, "Praemonstrator Start");

        queueVoiceAction(knock, hierophant, 1, 2);

        queueCircleMoveAction("Kerux Proclaim", kerux, 1);

        queueVoiceAction(001, kerux, 1);

        queueCircleMoveAction("Kerux Start", kerux, 1);

        //queueVoiceAction(knock, hierophant, 1);
        queueVoiceAction(knock, hierophant, 1);

        queue.addToQueue(new AllAction
        {
            actions = new ScriptAction[] {
                createStandAction("Hierophant Start Throne", hierophant),
                createStandAction("Hegemon Start Throne", hegemon),
                createStandAction("Hiereus Start Throne", hiereus),
                createStandAction("Stolistes Start Throne", stolistes),
                createStandAction("Dadouchos Start Throne", dadouchos)
            }
        });

        queueVoiceAction(knock, hierophant, 1);
        queueVoiceAction(002, hierophant, 1);

        queueMoveAction("Facing Door", kerux);
        queueVoiceAction(knock, kerux, 1);
        queueVoiceAction(knock, kerux, 1);
        queueMoveAction("Kerux Start", kerux);
        queueVoiceAction(003, kerux, 1);


        queueVoiceAction(004, hierophant, 1);
        // hiereus stands and goes to the door
        queueMoveAction("Hiereus Start Throne Stand", hiereus);

        queueCircleMoveAction("Gaurding Door", hiereus, 1);

        queueVoiceAction(005, hiereus, 1);

        queueVoiceAction(006, hiereus, 1);
        queueCircleMoveAction("Hiereus Start Throne Stand", hiereus, 1);
        queueMoveAction("Hiereus Start", hiereus);


        queueVoiceAction(007, hierophant, 1);
        queueVoiceAction(008, hierophant, 1);
        queueVoiceAction(009, hiereus, 1);
        queueVoiceAction(010, hierophant, 1);
        queueVoiceAction(011, hiereus, 1);
        queueVoiceAction(012, hierophant, 1);
        queueVoiceAction(013, hiereus, 1);
        

        queueVoiceAction(014, hierophant, 1);
        queueVoiceAction(015, hiereus, 1);
        queueVoiceAction(016, hierophant, 1);
        queueVoiceAction(017, dadouchos, 1);
        queueVoiceAction(018, hierophant, 1);
        queueVoiceAction(019, stolistes, 1);
        queueVoiceAction(020, hierophant, 1);
        queueVoiceAction(021, kerux, 1);
        queueVoiceAction(022, hierophant, 1);
        queueVoiceAction(023, hegemon, 1);
        queueVoiceAction(024, hierophant, 1);
        queueVoiceAction(025, hiereus, 1);
        queueVoiceAction(026, hierophant, 1);

        queueVoiceAction(027, hierophant, 1);
        queueVoiceAction(028, stolistes, 1);
        queueVoiceAction(032, dadouchos, 1);
        queueVoiceAction(029, stolistes, 1);
        queueVoiceAction(033, dadouchos, 1);
        queueVoiceAction(030, stolistes, 1);
        queueVoiceAction(034, dadouchos, 1);
        queueVoiceAction(031, stolistes, 1);
        queueVoiceAction(035, dadouchos, 1);

        queueVoiceAction(036, hierophant, 1);

        queueVoiceAction(037, hierophant, 1);
        queueVoiceAction(038, hierophant, 1);
        queueVoiceAction(039, hierophant, 1);
        queueVoiceAction(040, hierophant, 1);
        queueVoiceAction(041, hierophant, 1);

        queueVoiceAction(042, hierophant, 1);
        queueVoiceAction(043, kerux, 1);

        queueVoiceAction(044, hierophant, 1);
        queueVoiceAction(045, hiereus, 1);
        queueVoiceAction(046, hegemon, 1);

        queueVoiceAction(047, hiereus, 1);
        queueVoiceAction(048, hegemon, 1);
        queueVoiceAction(049, hierophant, 1);

        queueVoiceAction(050, hegemon, 1);
        queueVoiceAction(051, hierophant, 1);
        queueVoiceAction(052, hiereus, 1);


    }

    void Update()
    {

        queue.Update();

        if (fastForwardTo != null)
        {
            queue.fastForwardTo(fastForwardTo);
            fastForwardTo = null;
        }
        
    }


    private GameObject addActor(GameObject prefab, string markName)
    {
        var actor = Instantiate(prefab);
        actor.transform.parent = this.transform;

        queue.addToQueue(new SetPositionAction { markName = markName, actor = actor, waitAfter = 0 });
        return actor;
    }

    private GameObject addThrone(GameObject prefab, string markName)
    {
        var actor = Instantiate(prefab);
        actor.transform.parent = this.transform;

        actor.name = markName + " Throne";

        queue.addToQueue(new SetPositionAction { markName = markName, actor = actor, waitAfter = 0, offset = new Vector3(0, 0, -0.05f) });
        return actor;
    }

    private void hideMarks()
    {
        var marks = GameObject.FindGameObjectsWithTag("Mark");
        foreach (var mark in marks)
        {
            var mr = mark.GetComponentInChildren<MeshRenderer>();
            Destroy(mr.gameObject);
        }
    }


    private ScriptAction queueVoiceAction(int clipId, GameObject actor, float waitAfter = 1f, float waitBefore = 0)
    {
        return queueVoiceAction(getClip(clipId), actor, waitAfter, waitBefore);
    }
    private ScriptAction queueVoiceAction(AudioClip clip, GameObject actor, float waitAfter = 1f, float waitBefore = 0)
    {
        return queue.addToQueue(new VoiceAction { clip = clip, actor = actor, waitAfter = waitAfter, waitBefore = waitBefore });
    }

    private ScriptAction queueMoveAction(string markName, GameObject actor)
    {
        return queue.addToQueue(createMoveAction(markName, actor));
    }
    private ScriptAction queueMoveAction(string markName, GameObject actor, float waitAfter)
    {
        return queue.addToQueue(createMoveAction(markName, actor, waitAfter));
    }
    private ScriptAction createMoveAction(string markName, GameObject actor, float waitAfter = 1f)
    {
        return new MoveAction { markName = markName, actor = actor, speed = 2.0f, waitAfter = waitAfter };
    }

    private ScriptAction createStandAction(string markName, GameObject actor, float waitAfter = 1f)
    {
        return new MoveAction { markName = markName + " Stand", actor = actor, speed = UnityEngine.Random.RandomRange(0.5f, 1), waitAfter = waitAfter, waitBefore = UnityEngine.Random.RandomRange(0.1f, 1) };
    }


    private ScriptAction queueCircleMoveAction(string targetMarkName, GameObject actor, float waitAfter)
    {
        return queueCircleMoveAction(targetMarkName, actor, 2, waitAfter);
    }

    private ScriptAction queueCircleMoveAction(string targetMarkName, GameObject actor, float speed, float waitAfter)
    {
        return queue.addToQueue(new CircleMoveAction { actor = actor, waitAfter = waitAfter, centerMarkName = "Altar", targetMarkName = targetMarkName, radiusMarkName = "Circumabulation", speed = speed });
    }



}
