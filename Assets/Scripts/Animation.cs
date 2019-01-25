using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Animation : MonoBehaviour
{

    //Variables que apuntan a los joints del modelo Avatar1
    Transform spinbase;
    Transform spinemid;
    Transform neck;
    Transform head;
    Transform shoulderleft;
    Transform elbowleft;
    //Transform wristleft;
    Transform handleft;
    Transform shoulderright;
    Transform elbowright;
    //Transform wristright;
    Transform handtright;
    Transform hipleft;
    Transform kneeleft;
    Transform ankleleft;
    Transform footleft;
    Transform hipright;
    Transform kneeright;
    Transform ankleright;
    Transform footright;
    Transform spineshoulder;
    Transform handtipleft;
    Transform thumbleft;
    Transform handtipright;
    Transform thumbright;

    //varianles Ik



    public Vector3 prube;
    public GameObject lefthand;

    //Variables de extraccion de json
    public string path;
    public string jsonString;
    

    //Variables de animacion
    Animator animator;
    
    

    public SkeletonList skeletonList = new SkeletonList();


    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();


        spinbase = animator.GetBoneTransform(HumanBodyBones.Hips);
        spinemid = animator.GetBoneTransform(HumanBodyBones.Chest);
        neck = animator.GetBoneTransform(HumanBodyBones.Neck);
        head = animator.GetBoneTransform(HumanBodyBones.Head);
        shoulderleft = animator.GetBoneTransform(HumanBodyBones.LeftUpperArm);
        elbowleft = animator.GetBoneTransform(HumanBodyBones.LeftLowerArm);
        //wristleft = animator.GetBoneTransform(HumanBodyBones.LeftHand);
        handleft = animator.GetBoneTransform(HumanBodyBones.LeftHand);
        shoulderright = animator.GetBoneTransform(HumanBodyBones.RightUpperArm);
        elbowright = animator.GetBoneTransform(HumanBodyBones.RightLowerArm);
        //wristright = animator.GetBoneTransform(HumanBodyBones.RightHand);
        handtright = animator.GetBoneTransform(HumanBodyBones.RightHand);
        hipleft = animator.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
        kneeleft = animator.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
        ankleleft = animator.GetBoneTransform(HumanBodyBones.LeftFoot);
        footleft = animator.GetBoneTransform(HumanBodyBones.LeftToes);
        hipright = animator.GetBoneTransform(HumanBodyBones.RightUpperLeg);
        kneeright = animator.GetBoneTransform(HumanBodyBones.RightLowerLeg);
        ankleright = animator.GetBoneTransform(HumanBodyBones.RightFoot);
        footright = animator.GetBoneTransform(HumanBodyBones.RightToes);
        spineshoulder = animator.GetBoneTransform(HumanBodyBones.UpperChest);
        handtipleft = animator.GetBoneTransform(HumanBodyBones.LeftMiddleDistal);
        thumbleft = animator.GetBoneTransform(HumanBodyBones.LeftThumbDistal);
        handtipright = animator.GetBoneTransform(HumanBodyBones.RightMiddleDistal);
        thumbright = animator.GetBoneTransform(HumanBodyBones.LeftThumbDistal);
    }

    // Update is called once per frame
    void Update()
    {
        float mult = 12;

        path = "Assets/skeleton1540260050796.json";
        jsonString = File.ReadAllText(path);


        skeletonList = JsonUtility.FromJson<SkeletonList>(jsonString);


       

        int i = 1;  /* 
            spinbase.transform.position = new Vector3(skeletonList.skeleton[i].joints[0].cameraX, skeletonList.skeleton[i].joints[0].cameraY, skeletonList.skeleton[i].joints[0].cameraZ );
            spinemid.transform.position = new Vector3(skeletonList.skeleton[i].joints[1].cameraX, skeletonList.skeleton[i].joints[1].cameraY, skeletonList.skeleton[i].joints[1].cameraZ);
            neck.transform.position = new Vector3(skeletonList.skeleton[i].joints[2].cameraX, skeletonList.skeleton[i].joints[2].cameraY, skeletonList.skeleton[i].joints[2].cameraZ);
            head.transform.position = new Vector3(skeletonList.skeleton[i].joints[3].cameraX, skeletonList.skeleton[i].joints[3].cameraY, skeletonList.skeleton[i].joints[3].cameraZ);
            shoulderleft.transform.position = new Vector3(skeletonList.skeleton[i].joints[4].cameraX, skeletonList.skeleton[i].joints[4].cameraY, skeletonList.skeleton[i].joints[4].cameraZ);
            elbowleft.transform.position = new Vector3(skeletonList.skeleton[i].joints[5].cameraX, skeletonList.skeleton[i].joints[5].cameraY, skeletonList.skeleton[i].joints[5].cameraZ);
            wristleft.transform.position = new Vector3(skeletonList.skeleton[i].joints[6].cameraX, skeletonList.skeleton[i].joints[6].cameraY, skeletonList.skeleton[i].joints[6].cameraZ);
            handleft.transform.position = new Vector3(skeletonList.skeleton[i].joints[7].cameraX, skeletonList.skeleton[i].joints[7].cameraY, skeletonList.skeleton[i].joints[7].cameraZ);
            shoulderright.transform.position = new Vector3(skeletonList.skeleton[i].joints[8].cameraX, skeletonList.skeleton[i].joints[8].cameraY, skeletonList.skeleton[i].joints[8].cameraZ);
            elbowright.transform.position = new Vector3(skeletonList.skeleton[i].joints[9].cameraX, skeletonList.skeleton[i].joints[9].cameraY, skeletonList.skeleton[i].joints[9].cameraZ);
            wristright.transform.position = new Vector3(skeletonList.skeleton[i].joints[10].cameraX, skeletonList.skeleton[i].joints[10].cameraY, skeletonList.skeleton[i].joints[10].cameraZ);
            handtright.transform.position = new Vector3(skeletonList.skeleton[i].joints[11].cameraX, skeletonList.skeleton[i].joints[11].cameraY, skeletonList.skeleton[i].joints[11].cameraZ);
            hipleft.transform.position = new Vector3(skeletonList.skeleton[i].joints[12].cameraX, skeletonList.skeleton[i].joints[12].cameraY, skeletonList.skeleton[i].joints[12].cameraZ);
            kneeleft.transform.position = new Vector3(skeletonList.skeleton[i].joints[13].cameraX, skeletonList.skeleton[i].joints[13].cameraY, skeletonList.skeleton[i].joints[13].cameraZ);
            ankleleft.transform.position = new Vector3(skeletonList.skeleton[i].joints[14].cameraX, skeletonList.skeleton[i].joints[14].cameraY, skeletonList.skeleton[i].joints[14].cameraZ);
            footleft.transform.position = new Vector3(skeletonList.skeleton[i].joints[15].cameraX, skeletonList.skeleton[i].joints[15].cameraY, skeletonList.skeleton[i].joints[15].cameraZ);
            hipright.transform.position = new Vector3(skeletonList.skeleton[i].joints[16].cameraX, skeletonList.skeleton[i].joints[16].cameraY, skeletonList.skeleton[i].joints[16].cameraZ);
            kneeright.transform.position = new Vector3(skeletonList.skeleton[i].joints[17].cameraX, skeletonList.skeleton[i].joints[17].cameraY, skeletonList.skeleton[i].joints[17].cameraZ);
            ankleright.transform.position = new Vector3(skeletonList.skeleton[i].joints[18].cameraX, skeletonList.skeleton[i].joints[18].cameraY, skeletonList.skeleton[i].joints[18].cameraZ);
            footright.transform.position = new Vector3(skeletonList.skeleton[i].joints[19].cameraX, skeletonList.skeleton[i].joints[19].cameraY, skeletonList.skeleton[i].joints[19].cameraZ);
            handtipleft.transform.position = new Vector3(skeletonList.skeleton[i].joints[21].cameraX, skeletonList.skeleton[i].joints[21].cameraY, skeletonList.skeleton[i].joints[21].cameraZ);
            thumbleft.transform.position = new Vector3(skeletonList.skeleton[i].joints[22].cameraX, skeletonList.skeleton[i].joints[22].cameraY, skeletonList.skeleton[i].joints[22].cameraZ);
            handtipright.transform.position = new Vector3(skeletonList.skeleton[i].joints[23].cameraX, skeletonList.skeleton[i].joints[23].cameraY, skeletonList.skeleton[i].joints[23].cameraZ);
            thumbright.transform.position = new Vector3(skeletonList.skeleton[i].joints[24].cameraX, skeletonList.skeleton[i].joints[24].cameraY, skeletonList.skeleton[i].joints[24].cameraZ);
            */

        
        
            spinbase.position = new Vector3(skeletonList.skeleton[i].joints[0].cameraX * mult, skeletonList.skeleton[i].joints[0].cameraY * mult, skeletonList.skeleton[i].joints[0].cameraZ * mult);
            spinemid.position = new Vector3(skeletonList.skeleton[i].joints[1].cameraX * mult, skeletonList.skeleton[i].joints[1].cameraY * mult, skeletonList.skeleton[i].joints[1].cameraZ * mult);
            neck.position = new Vector3(skeletonList.skeleton[i].joints[2].cameraX * mult, skeletonList.skeleton[i].joints[2].cameraY * mult, skeletonList.skeleton[i].joints[2].cameraZ * mult);
            head.position = new Vector3(skeletonList.skeleton[i].joints[3].cameraX * mult, skeletonList.skeleton[i].joints[3].cameraY * mult, skeletonList.skeleton[i].joints[3].cameraZ * mult);
            shoulderleft.position = new Vector3(skeletonList.skeleton[i].joints[4].cameraX * mult, skeletonList.skeleton[i].joints[4].cameraY * mult, skeletonList.skeleton[i].joints[4].cameraZ * mult);
            //elbowleft.position = new Vector3(skeletonList.skeleton[i].joints[5].cameraX * mult, skeletonList.skeleton[i].joints[5].cameraY * mult, skeletonList.skeleton[i].joints[5].cameraZ * mult);
            //wristleft.position = new Vector3(skeletonList.skeleton[i].joints[6].cameraX * mult, skeletonList.skeleton[i].joints[6].cameraY * mult, skeletonList.skeleton[i].joints[6].cameraZ * mult);
            //handleft.position = new Vector3(skeletonList.skeleton[i].joints[7].cameraX * mult, skeletonList.skeleton[i].joints[7].cameraY * mult, skeletonList.skeleton[i].joints[7].cameraZ * mult);
            shoulderright.position = new Vector3(skeletonList.skeleton[i].joints[8].cameraX * mult, skeletonList.skeleton[i].joints[8].cameraY * mult, skeletonList.skeleton[i].joints[8].cameraZ * mult);
            //elbowright.position = new Vector3(skeletonList.skeleton[i].joints[9].cameraX * mult, skeletonList.skeleton[i].joints[9].cameraY * mult, skeletonList.skeleton[i].joints[9].cameraZ * mult);
            //wristright.position = new Vector3(skeletonList.skeleton[i].joints[10].cameraX * mult, skeletonList.skeleton[i].joints[10].cameraY * mult, skeletonList.skeleton[i].joints[10].cameraZ * mult);
            //handtright.position = new Vector3(skeletonList.skeleton[i].joints[11].cameraX * mult, skeletonList.skeleton[i].joints[11].cameraY * mult, skeletonList.skeleton[i].joints[11].cameraZ * mult);
            hipleft.position = new Vector3(skeletonList.skeleton[i].joints[12].cameraX * mult, skeletonList.skeleton[i].joints[12].cameraY * mult, skeletonList.skeleton[i].joints[12].cameraZ * mult);
            kneeleft.position = new Vector3(skeletonList.skeleton[i].joints[13].cameraX * mult, skeletonList.skeleton[i].joints[13].cameraY * mult, skeletonList.skeleton[i].joints[13].cameraZ * mult);
            ankleleft.position = new Vector3(skeletonList.skeleton[i].joints[14].cameraX * mult, skeletonList.skeleton[i].joints[14].cameraY * mult, skeletonList.skeleton[i].joints[14].cameraZ * mult);
            footleft.position = new Vector3(skeletonList.skeleton[i].joints[15].cameraX * mult, skeletonList.skeleton[i].joints[15].cameraY * mult, skeletonList.skeleton[i].joints[15].cameraZ * mult);
            hipright.position = new Vector3(skeletonList.skeleton[i].joints[16].cameraX * mult, skeletonList.skeleton[i].joints[16].cameraY * mult, skeletonList.skeleton[i].joints[16].cameraZ * mult);
            kneeright.position = new Vector3(skeletonList.skeleton[i].joints[17].cameraX * mult, skeletonList.skeleton[i].joints[17].cameraY * mult, skeletonList.skeleton[i].joints[17].cameraZ * mult);
            ankleright.position = new Vector3(skeletonList.skeleton[i].joints[18].cameraX * mult, skeletonList.skeleton[i].joints[18].cameraY * mult, skeletonList.skeleton[i].joints[18].cameraZ * mult);
            footright.position = new Vector3(skeletonList.skeleton[i].joints[19].cameraX * mult, skeletonList.skeleton[i].joints[19].cameraY * mult, skeletonList.skeleton[i].joints[19].cameraZ * mult);
        /*handtipleft.position = new Vector3(skeletonList.skeleton[i].joints[21].cameraX * mult, skeletonList.skeleton[i].joints[21].cameraY * mult, skeletonList.skeleton[i].joints[21].cameraZ * mult);
        thumbleft.position = new Vector3(skeletonList.skeleton[i].joints[22].cameraX * mult, skeletonList.skeleton[i].joints[22].cameraY * mult, skeletonList.skeleton[i].joints[22].cameraZ * mult);
        handtipright.position = new Vector3(skeletonList.skeleton[i].joints[23].cameraX * mult, skeletonList.skeleton[i].joints[23].cameraY * mult, skeletonList.skeleton[i].joints[23].cameraZ * mult);
        thumbright.position = new Vector3(skeletonList.skeleton[i].joints[24].cameraX * mult, skeletonList.skeleton[i].joints[24].cameraY * mult, skeletonList.skeleton[i].joints[24].cameraZ * mult);
        */

     
        Debug.Log(spinbase.transform.rotation.x);

        StartCoroutine(Timer());
  
        

    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(50);

    }
    
    private void OnAnimatorIK(int layerIndex)
    {
        float mult = 88;

        skeletonList = JsonUtility.FromJson<SkeletonList>(jsonString);

        int i = 1;

        //Mano izquierda
        animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
        animator.SetIKPosition(AvatarIKGoal.LeftHand, new Vector3(skeletonList.skeleton[i].joints[7].cameraX * mult, skeletonList.skeleton[i].joints[7].cameraY * mult, skeletonList.skeleton[i].joints[7].cameraZ * mult));

        //Codo izquierdo
        animator.SetIKHintPositionWeight(AvatarIKHint.LeftElbow, 1);
        animator.SetIKHintPosition(AvatarIKHint.LeftElbow, new Vector3(skeletonList.skeleton[i].joints[5].cameraX * mult, skeletonList.skeleton[i].joints[5].cameraY * mult, skeletonList.skeleton[i].joints[5].cameraZ * mult));

        
        //float reachRightHand = animator.GetFloat("RightHandReach");
        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        animator.SetIKPosition(AvatarIKGoal.RightHand, new Vector3(skeletonList.skeleton[i].joints[11].cameraX * mult, skeletonList.skeleton[i].joints[11].cameraY * mult, skeletonList.skeleton[i].joints[11].cameraZ * mult));

        //Codo derecho
        //float reachElbowright = animator.GetFloat("LeftHandReach");
        animator.SetIKHintPositionWeight(AvatarIKHint.RightElbow, 1);
        animator.SetIKHintPosition(AvatarIKHint.RightElbow, new Vector3(skeletonList.skeleton[i].joints[9].cameraX * mult, skeletonList.skeleton[i].joints[9].cameraY * mult, skeletonList.skeleton[i].joints[9].cameraZ * mult));
        




    }
    
}



[System.Serializable]
public class Joints
{
    public float depthX;
    public float depthY;
    public float colorX;
    public float colorY;
    public float cameraX;
    public float cameraY;
    public float cameraZ;
    public float orientationX;
    public float orientationY;
    public float orientationZ;
    public float orientationW;
}

[System.Serializable]
public class Skeleton
{
    public int bodyIndex;
    public bool tracked;
    public char trackingId;
    public int leftHandState;
    public int rightHandState;
    public Joints[] joints;
    public double record_startime;
    public double record_timestamp;
}

[System.Serializable]
public class SkeletonList
{
    public Skeleton[] skeleton;
}
