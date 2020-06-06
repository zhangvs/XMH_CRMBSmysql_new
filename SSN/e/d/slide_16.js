var Show_Style=3;
var Image_16=new Array();
var Pics="/e/images/banner/banner-1.png";
var Links="";
var Titles="";
var Alts="";
var Apic16=Pics.split('|');
var ALink16=Links.split('|');
var ATitle16=Titles.split('|');
var AAlts16=Alts.split('|');
var Show_Text=0;
for(i=0;i<Apic16.length;i++)
  {
   Image_16.src = Apic16[i]; 
  }



  var FHTML='<div id="js_slide_focus_16" class="slide_focus focus_style3" style="height:300px"><a class="prev"></a><a class="next"></a>';
  FHTML+='<ul class="inner">';
  for(var i=0;i<Apic16.length;i++)
   {
     if(ALink16.length<(i+1) || ALink16[i]=="")
      {
       ALink16[i]="javascript:void(0)";
      }
     if(AAlts16.length<(i+1))
      {
       AAlts16[i]="";
      }
     if(ATitle16.length<(i+1))
      {
       ATitle16[i]="";
      }
    FHTML+='<li><a href="'+ALink16[i]+'" target="_self" title="'+AAlts16[i]+'"><img src="'+Apic16[i]+'">';
    FHTML+='<em>'+ATitle16[i]+'</em>';
    FHTML+='</a></li>';
   }
 FHTML+='</ul>';
 FHTML+='</div>';
 document.write(FHTML);
$(function(){Slide_Focus("js_slide_focus_16",0,5,1920,300,true);});