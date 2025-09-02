$(function () {
  $('.menu-item').on('mouseenter', function () {
    $(this).find('.mega-menu').addClass('fade-up');
  });
  
  $('.menu-item').on('mouseleave', function () {
    $(this).find('.mega-menu').removeClass('fade-up');
  });
  
  let menuTimer; // تایمر برای کنترل تأخیر باز شدن
  
  $('.menu-level-1 .menu-link').on('mouseenter', function () {
    $(this).addClass('active');
    let submenu = $(this).next('.menu-level-2');
    
    // تنظیم تایمر برای نمایش بعد از 200 میلی‌ثانیه
    menuTimer = setTimeout(function () {
      $('.menu-level-2').css('display', 'none');
      $(submenu).css('display', 'block');
    }, 200);
  });
  
  $('.menu-level-1 .menu-link').on('mouseleave', function () {
    $(this).removeClass('active');
    let $submenu = $(this).find('.menu-level-2');

    // اگر موس قبل از 200 میلی‌ثانیه از منو خارج شد، تایمر لغو شود
    clearTimeout(menuTimer);
  });

  // زمانی که موس روی زیرمنو رفت، نباید بسته شود
  $('.menu-level-2').on('mouseenter', function () {
    $(this).prev().addClass('active');
    clearTimeout(menuTimer);
  });
  
  // زمانی که موس از زیرمنو خارج شد، آن را ببندد
  $('.menu-level-2').on('mouseleave', function () {
    $(this).prev().removeClass('active');
    $(this).css('display', 'block');
  });

  // search form js
  $('.search-form').on('input', function () {
    let searchValue = $(this).find('.search-input').val();
    if (searchValue.length > 0) {
      $(this).find('.search-image').addClass('d-none');
    } else {
      $(this).find('.search-image').removeClass('d-none');
    }
  });

  // mobile menu
  let isOpen = false;
  $('#open-mobile-menu-btn').on('click', function () {
    if (isOpen) {
      $('body').css("overflow","initial");
      $('#mobile-menu').css('top', '100%');
      $(this).find('.icon').removeClass('icon-category-2').addClass('icon-category')
      isOpen = false;
    } else {
      $('body').css("overflow","hidden");
      $('#mobile-menu').css('top', '86px');
      $(this).find('.icon').removeClass('icon-category').addClass('icon-category-2')
      isOpen = true;
    }
  });
});
