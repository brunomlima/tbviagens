/*
	Travel Theme's menu.js
	Copyright: 2012-2015, D5 Creation, www.d5creation.com
	License: GNU GPL V2
	Since Travel 1.0
*/

jQuery(document).ready(function(){ jQuery("#travel-main-menu ul ul").css({display: "none"}); jQuery('#travel-main-menu ul li').hover( function() { jQuery(this).find('ul:first').slideDown(200).css('visibility', 'visible'); jQuery(this).addClass('selected'); }, function() { jQuery(this).find('ul:first').slideUp(200); jQuery(this).removeClass('selected'); }); });

jQuery(document).ready(function(){ jQuery("ul.lboxd ul").css({display: "none"}); jQuery('ul.lboxd li').hover( function() { jQuery(this).find('ul:first').slideDown(200).css('visibility', 'visible'); jQuery(this).addClass('selected'); }, function() { jQuery(this).find('ul:first').slideUp(200); jQuery(this).removeClass('selected'); }); });