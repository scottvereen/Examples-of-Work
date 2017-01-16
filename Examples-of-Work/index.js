/**
 * Created by 001402079 on 12/8/2016.
 */
$(function (){

    if (localStorage.getItem('loggedIN') === null){
        $('.loginDash').attr('style','visibility: show');
        $('.userDash').attr('style','visibility: hidden');
    }
    else {
        $('.loginDash').attr('style','visibility: hidden');
        $('.userDash').attr('style','visibility: show');
    }
    $('#btnInvite').on('click', function(){
        alert('clicked');
        var invite = $('#txtInvite').val();
        $('#matchups').append('<li><a href="matchups.html"><i class="material-icons deep-orange-text right">delete</i>'+ invite +' pending...</a></li>')
    });

    $('#btnSubmit').on('click', function(){
        $('.loginDash').attr('style','visibility: hidden');
        $('.userDash').attr('style','visibility: show');
        localStorage.setItem('loggedIN', true);

    })
    $('#signout').on('click', function(){
        localStorage.clear();
        document.location.href="index.html";

    })
    $('#btnLogin').on('click', function(){
        $('#lblLogin').text('Login');
        $('#txtEmail').hide();
    })
    $('#btnSignup').on('click', function(){
        $('#lblLogin').text('Signup');
        $('#txtEmail').show();
    })
    $(window).resize(function(){
        if($(window).width() < 960){
            $('header, main, footer').attr('style', 'padding-left:150px')
        }
        if($(window).width() < 500){
            $('header, main, footer').attr('style', 'padding-left:0px')
        }
        if($(window).width() > 500) {
            $('header, main, footer').attr('style', 'padding-left:75px')
        }
        if($(window).width() > 960){
            $('header, main, footer').attr('style', 'padding-left:300px')
        }
    });
});

