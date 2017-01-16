/**
 * Created by User on 12/8/2016.
 */
$(function (){
$.getJSON('scrapedData/QB.txt', function (data) {
    var tbl = "";
    var index = 0;
    $.each(data , function (key, val){

        tbl += ("<tr><td>" + data[index].Name + "</td><td>" + data[index].Opp + "</td><td>" + data[index].Points + "</td></tr>" );
        index++;
    });
    $(tbl).appendTo( "#qb" );
});

$.getJSON('scrapedData/RB.txt', function (data) {
    var tbl = "";
    var index = 0;
    $.each(data , function (key, val){

        tbl += ("<tr><td>" + data[index].Name + "</td><td>" + data[index].Opp + "</td><td>" + data[index].Points + "</td></tr>" );
        index++;
    });
    $(tbl).appendTo( "#rb" );
});

$.getJSON('scrapedData/WR.txt', function (data) {
    var tbl = "";
    var index = 0;
    $.each(data , function (key, val){

        tbl += ("<tr><td>" + data[index].Name + "</td><td>" + data[index].Opp + "</td><td>" + data[index].Points + "</td></tr>" );
        index++;
    });
    $(tbl).appendTo( "#wr" );
});

$.getJSON('scrapedData/TE.txt', function (data) {
    var tbl = "";
    var index = 0;
    $.each(data , function (key, val){

        tbl += ("<tr><td>" + data[index].Name + "</td><td>" + data[index].Opp + "</td><td>" + data[index].Points + "</td></tr>" );
        index++;
    });
    $(tbl).appendTo( "#te" );
});

$.getJSON('scrapedData/DST.txt', function (data) {
    var tbl = "";
    var index = 0;
    $.each(data , function (key, val){

        tbl += ("<tr><td>" + data[index].Name + "</td><td>" + data[index].Opp + "</td><td>" + data[index].Points + "</td></tr>" );
        index++;
    });
    $(tbl).appendTo( "#dst" );
});

$.getJSON('scrapedData/K.txt', function (data) {
    var tbl = "";
    var index = 0;
    $.each(data , function (key, val){

        tbl += ("<tr><td>" + data[index].Name + "</td><td>" + data[index].Opp + "</td><td>" + data[index].Points + "</td></tr>" );
        index++;
    });
    $(tbl).appendTo( "#ks" );
});
});