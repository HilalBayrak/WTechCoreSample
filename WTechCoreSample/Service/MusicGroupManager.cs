using System;
using System.Collections.Generic;
using WTechCoreSample.Models;

namespace WTechCoreSample.Service
{
    public class MusicGroupManager
    {

        public static List<GroupMember> GetAllMembers()
        {

  

            MusicGroup group1 = new MusicGroup();
            group1.Id = 1;
            group1.Name = "Iron Maiden";
            group1.Country = "UK";
            group1.Description = "Iron Maiden, 1975 yılında Londra'da kurulmuş bir İngiliz heavy metal grubudur. Grup basçı Steve Harris tarafından kurulmuştur. ";


            MusicGroup group2 = new MusicGroup();
            group2.Id = 2;
            group2.Name = "Slipknot";
            group2.Country = "ABD";
            group2.Description = "Slipknot, 1995 yılında Des Moines, Iowa'da kurulmuş Nu metal grubudur. Slipknot'un şu anki mevcut üyeleri Sid Wilson, Alessandro Venturella, New Guy, James Root, Craig  Jones, Shawn Crahan, Mick Thomson, Jay Weinberg ve Corey Taylor'dır";





            GroupMember member1 = new GroupMember();
            member1.Id = 1;
            member1.Name = "Steve";
            member1.Surname = "Harris";
            member1.MusicalEnstrument = "Bass guitar";
            member1.Story = "Steve Harris, Iron Maiden grubunun kurucusu, bas gitaristi, geri vokalisti ve baş bestecisidir. Ayrıca stüdyo kayıtlarında zaman zaman klavye de çalar. Grubu 1975 yılında kurmuştur. Dave Murray ile birlikte grubun ilk albümünde yer alan kadroda değişmeyen iki elemandan biridir.";
            member1.MusicCompany = "EMI";
            member1.MusicGroup = group1;

            GroupMember member2 = new GroupMember();
            member2.Id = 2;
            member2.Name = "Bruce";
            member2.Surname = "Dickinson";
            member2.MusicalEnstrument = "Soloist";
            member2.MusicGroup = group1;
            member2.Story = "Bruce Dickinson Iron Maiden'ın vokalistidir ve solo albümler de yapmaktadır. Gerçek hayatta pilot, yayımcı, yazar, senarist ve eskrimcidir. Güçlü sesi ile dünyanın en önemli heavy metal vokallerinden biri olarak görülmektedir. Arthur Brown, Peter Hamill, Ian Anderson ve Ian Gillan'dan etkilenmiştir";
            member2.MusicCompany = "EMI";



          


            GroupMember member3 = new GroupMember();
            member3.Id = 3;
            member3.Name = "Paul";
            member3.Surname = "Gray";
            member3.MusicalEnstrument = "Bass guitar";
            member3.MusicGroup = group2;
            member3.Story = "Paul Gray Slipknot'ın kurucularındandır. Grubun bas gitaristi söz yazarı ve arka vokalidir. Sol elle çalar. Gruptaki numarası #2'dir. 24 Mayıs 2010'da ölmüştür. Grubun Iowa'da doğmayan üyelerindendir.";
            member3.MusicCompany = "EMI";


            GroupMember member4 = new GroupMember();
            member4.Id = 4;
            member4.Name = "Corey";
            member4.Surname = "Taylor";
            member4.MusicalEnstrument = "Soloist";
            member4.MusicGroup = group2;
            member4.Story = "Corey Taylor, Slipknot ve Stone Sour'da vokalistlik yapan Nu Metal vokalisti. İlk eşinin adı Scarlett'tir. İkinci eşinin adı ise Stephanie'dir. Ayrıca Slipknot dışında diğer sanatçılarla da ortak çalışmalar yapmaktadır. Apocalyptica hayranıdır. ";
            member4.MusicCompany = "EMI";

            List<GroupMember> allMembers = new List<GroupMember>();

            allMembers.Add(member1);
            allMembers.Add(member2);
            allMembers.Add(member3);
            allMembers.Add(member4);



            return allMembers;




        }

    }
}
