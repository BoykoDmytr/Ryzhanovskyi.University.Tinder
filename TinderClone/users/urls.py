from django.urls import path

from .views import match_views
from .views import views
from .views import like_views

from django.conf import settings
from django.conf.urls.static import static

urlpatterns = [
    path("", views.home),
    path('navbar', views.navbar, name='navbar'),
    path('googleLogin/', views.googleLogin, name='googleLogin'),
    path('profile/<str:username>/', views.profile_detail, name='profile_detail'),
    path('profile_creation/', views.create_profile, name='profile_creation'),
    path("logout/", views.logout_view, name='logout'),
    path("card/", match_views.view_that_shows_card, name='card'),
    path('next-profile/', match_views.card_views, name='next_profile'),
    path('redirect_after_login/', views.redirect_after_login, name='redirect_after_login'),
    path('like/<str:username>/', like_views.like_profile, name='like_profile'),
]

if settings.DEBUG:
    urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)
