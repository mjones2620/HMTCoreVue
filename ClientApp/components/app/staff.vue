<template>
    <section id="ourStaff" class="parallax">
        <div class="parallax-overlay">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="section-content text-center">
                            <h2>Meet Us</h2>
                            <hr class="botm-line" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3" v-for="(profile, index) in filteredProfiles" :key="profile.name">
                        <div class="card hovercard">
                            <div v-bind:class="[{ cardheader : true}]">
                            </div>
                            <div class="avatar">
                                <img alt="" :src="profile.imagePath">
                            </div>
                            <div class="info">
                                <div class="title">
                                    <span>{{profile.name}}</span>
                                </div>
                                <div class="desc" v-if="profile.specialJobDesignation">{{profile.specialJobDesignation}}</div>
                                <div class="desc">{{profile.title}}</div>
                                <div class="desc">{{profile.locationDescription}}</div>
                            </div>
                            <div class="bottom">
                                <button type="button" class="btn btn-default" data-toggle="modal" :data-target="'#' + index">View Profile</button>
                            </div>
                        </div>
                        <div :id="index" class="modal fade" role="dialog">
                            <div class="modal-dialog">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <div class="col-md-12">
                                            <div class="info">
                                                <h1>{{profile.name}}</h1>
                                                <h4>{{profile.title}}</h4>
                                                <h4 v-if="profile.specialJobDesignation">{{profile.specialJobDesignation}}</h4>
                                            </div>
                                            <div id="aboutMe">
                                                <div class="text-center">
                                                    <hr class="botm-line" />
                                                </div>
                                                <h4>About {{profile.name}}</h4>
                                                <div v-html="profile.bio"></div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</template>

<script>
    import _ from "lodash"

    export default {
        name: 'staff',
        data() {
            return {
                profiles: []
            }
        },
        computed: {
            filteredProfiles(){
                if(this.profiles){
                    this.profiles.forEach(profile => {
                        profile.imagePath = `images/${profile.imagePath}`;
                    });
                    return _.sortBy(this.profiles, ['orderIndex']);
                }
            }
        },
        created() {
            this.$http.get("StaffProfiles")
                .then(response => {
                    this.profiles = response.data;
                });
        }
    }
</script>