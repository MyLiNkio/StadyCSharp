
SELECT uid, profile_id FROM facebook.user where uid = 52508; /*profile_id*/
SELECT mm_promos_section_id FROM facebook.skynet_profile WHERE profile_id = 19901;/*39*/
SELECT platform_type_id FROM facebook.platform WHERE platform_id = 1;/*1*/

SELECT * FROM facebook.skynet_profile_section_config where profile_section_type_id=9001;

      
SELECT * FROM facebook.skynet_profile_section_config
    WHERE profile_section_type_id = 9001
      AND platform_type_id = 1
      AND profile_section_id = 39;